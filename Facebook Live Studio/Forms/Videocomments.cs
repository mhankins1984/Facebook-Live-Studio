using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Facebook;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;
using System.Configuration;
using System.Linq;

namespace Facebook_Live_Studio.Forms
{
    public partial class Videocomments : Form
    {
        public Videocomments()
        {
            InitializeComponent();
        }
        //
        // Get required app.config values
        //
        public string ChyronAddress
        {
            get
            {
                return ConfigurationManager.AppSettings["ChyronAddress"];
            }
        }
        int current_still;
        int next_still;
        string server;

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void dataGridView3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        DataTable table1 = new DataTable(); // Que table
        DataTable table2 = new DataTable(); // Play table
        DataTable table3 = new DataTable(); // Log table
        //
        // Chyron xml output
        //
        void outputXmL(string name, string comment)
        {
            ChyronData cd = new ChyronData();

            cd.PageType = "facebook_template_1";
            cd.TemplatePageNumber = "201";
            cd.BuildPageNumber = "1001";
            cd.Name = name;
            cd.Comment = comment;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(cd.GetType());
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"\\10.176.4.104\ProjectParking\Election2016XML\ConstituencyXML\feedback.xml");
            x.Serialize(sw, cd);
            sw.Close();
        }
        //
        // video comment classes
        //
        public class From
        {
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Datum
        {
            public string created_time { get; set; }
            public From from { get; set; }
            public string message { get; set; }
            public string id { get; set; }
        }

        public class Cursors
        {
            public string before { get; set; }
            public string after { get; set; }
        }

        public class Paging
        {
            public Cursors cursors { get; set; }
        }

        public class RootObject
        {
            public IList<Datum> data { get; set; }
            public Paging paging { get; set; }
        }

        void sendastring(String w)
        {
            Debug.WriteLine(String.Format("Chyron Address : {0}", ChyronAddress));
            server = ChyronAddress;
            Int32 port = 23;
            TcpClient client = new TcpClient(server, port);
            Debug.WriteLine(String.Format("Chyron Address : {0}", client.Client.RemoteEndPoint));

            NetworkStream stream = client.GetStream();

            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(w);
            Debug.WriteLine(data + " Data Length : " + data.Length);

            // Get a client stream for reading and writing.
            Debug.WriteLine(String.Format("Is controlling:{0}, stream read : {1}, write : {2} client connected : {3}", ChyronAddress, stream.CanRead, stream.CanWrite, client.Connected));

            // Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length);

            Debug.WriteLine(String.Format("Sent: {0}", w));
            Thread.Sleep(200);
            // Receive the TcpServer.response.

            // Buffer to store the response bytes.
            data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            {
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                responseData.Replace("\r\n\r\n", "\r\n");
            }
            // catch { }
            Debug.WriteLine(String.Format("Received: {0}", responseData));

            // Close everything.
            stream.Close();
            client.Close();
        }

        private void Videocomments_Load(object sender, EventArgs e)
        {
            if (Videoselector.VideoID == null) // Checks if VideoID null
            {
                var Videoselector = new Videoselector();
                Videoselector.ShowDialog(this);
            }

            else { }

            if (Videoselector.VideoID == null) // Checks if VideoID null
            {
                this.Close();
                timer1.Stop();
            }

            else { }
            //
            // Create columns in tables for tempory data storage
            //
            table1.Columns.Add("CommentID", typeof(string));
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Comment", typeof(string));
            table2.Columns.Add("CommentID", typeof(string));
            table2.Columns.Add("Name", typeof(string));
            table2.Columns.Add("Comment", typeof(string));
            table3.Columns.Add("CommentID", typeof(string));
            table3.Columns.Add("Name", typeof(string));
            table3.Columns.Add("Comment", typeof(string));

            InitTimer();
            //
            // Get video comments data
            //
            var fb = new FacebookClient(Authorise.PageAccessToken);
            var LiveVideosComments = string.Format(
                    @"{0}/comments?limit=1000&order=reverse_chronological",
                    Videoselector.VideoID);
            var result = fb.Get(LiveVideosComments);
            string json = result.ToString();
            //
            // Deserialize JSON data
            //
            RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);
            //
            // dataGridView1 autosize
            //
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // dataGridView text wrap
            //
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView3.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            // dataGridView select only one and whole row
            //
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView2_RowPrePaint);
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            dataGridView3.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView3_RowPrePaint);

            int i = 0;

            foreach (Datum d in rootobject.data)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = d.id;
                dataGridView1.Rows[i].Cells[1].Value = d.from.name;
                dataGridView1.Rows[i++].Cells[2].Value = d.message;
            }
        }

        private System.Windows.Forms.Timer timer1;
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Videoselector.VideoID == null)
            {
                timer1.Stop();
            }

            else
            {
                timer1.Interval = 5000; // in miliseconds
                //
                // Get video comments data
                //
                var fb = new FacebookClient(Authorise.PageAccessToken);
                var LiveVideosComments = string.Format(
                        @"{0}/comments?limit=1000&order=reverse_chronological",
                        Videoselector.VideoID);
                var result = fb.Get(LiveVideosComments);

                string json = result.ToString();
                //
                // Deserialize JSON data
                //
                RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);

                int i = 0;

                dataGridView1.Rows.Clear();
                foreach (Datum d in rootobject.data)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = d.id;
                    dataGridView1.Rows[i].Cells[1].Value = d.from.name;
                    dataGridView1.Rows[i++].Cells[2].Value = d.message;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Interval = 30000; // in miliseconds
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            int c1 = dataGridView1.SelectedRows.Count;
            if (c1 > 0) // Checks if a comment has been selected
            {
                string cc = dataGridView1.SelectedCells[2].Value.ToString();
                if (cc.Length > 170) // Checks if comment under 170 characters
                {
                    System.Windows.Forms.MessageBox.Show("Comment cannot be added. Comment over 170 characters.", "Information");
                }

                else
                {
                    bool exists = table3.Select().ToList().Exists(row => row["CommentID"].ToString().ToUpper() == dataGridView1.SelectedCells[0].Value.ToString());

                    if (exists == true) // Check if comment already used.
                    { System.Windows.Forms.MessageBox.Show("Comment has already been used.", "Information"); }

                    else
                    {

                        int c3 = dataGridView3.SelectedRows.Count;

                        if (c3 > 0) // Checks if play next has comment
                        {
                            table1.Rows.Add(dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[1].Value, dataGridView1.SelectedCells[2].Value); // Add to que table
                            table3.Rows.Add(dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[1].Value, dataGridView1.SelectedCells[2].Value); // Add to log table
                            dataGridView2.DataSource = table1;
                            //
                            // Autosize
                            //
                            this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            this.dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                            //
                            // Hide CommentID from datagridview view
                            //
                            dataGridView2.Columns[0].Visible = false;
                        }

                        else
                        {
                            table2.Rows.Add(dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[1].Value, dataGridView1.SelectedCells[2].Value); // Add to play table
                            table3.Rows.Add(dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[1].Value, dataGridView1.SelectedCells[2].Value); // Add to log table
                            dataGridView3.DataSource = table2;
                            //
                            // Autosize
                            //
                            this.dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            this.dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                            //
                            // Hide CommentID from datagridview view
                            //
                            dataGridView3.Columns[0].Visible = false;

                            string name = dataGridView3.SelectedCells[1].Value.ToString();
                            string comment = dataGridView3.SelectedCells[2].Value.ToString();

                            outputXmL(name, comment);

                            Thread.Sleep(500); // in miliseconds
                            String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";

                            sendastring(V5);
                            current_still = next_still;
                        }
                    }
                }
            }
            else { System.Windows.Forms.MessageBox.Show("No comment selected.", "Information"); }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1; // in miliseconds
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int c2 = dataGridView3.SelectedRows.Count;
            if (c2 > 0)  // Checks if que has comment
            {
                String V6;
                //
                // Chyron graphic play
                //
                V6 = @"V\6\1\1\\" + "\r\n";

                Byte[] data_response = new Byte[256];

                Thread.Sleep(100); // in miliseconds

                sendastring(V6);
                Thread.Sleep(500); // in miliseconds

                foreach (DataGridViewRow row in dataGridView3.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dataGridView3.Rows.Remove(row);
                }
                 
                int c3 = dataGridView2.SelectedRows.Count;
                if (c3 > 0) // Checks if play next has comment
                {
                    string name = dataGridView2.SelectedCells[1].Value.ToString();
                    string comment = dataGridView2.SelectedCells[2].Value.ToString();

                    outputXmL(name, comment);

                    Thread.Sleep(500); // in miliseconds

                    table2.Rows.Add(dataGridView2.SelectedCells[0].Value, dataGridView2.SelectedCells[1].Value, dataGridView1.SelectedCells[2].Value);
                    dataGridView3.DataSource = table2;
                    //
                    // Autosize
                    //
                    this.dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    //
                    // Hide CommentID from datagridview view
                    //
                    dataGridView3.Columns[0].Visible = false;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        if (!row.IsNewRow)
                            dataGridView2.Rows.Remove(row);
                    }


                    String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";

                    sendastring(V5);
                    current_still = next_still;
                }

                else { }
            }
            else {
                System.Windows.Forms.MessageBox.Show("No comment to play.", "Information");
            }
        }
    }
}