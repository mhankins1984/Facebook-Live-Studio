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
using System.IO;
using System.Drawing;

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

        private void CommentsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void QueDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void PlayDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        DataTable QueTable = new DataTable(); // Que table
        DataTable PlayTable = new DataTable(); // Play table
        DataTable LogTable = new DataTable(); // Log table
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
        //
        // Studio Out
        //
        public static string Q1N { get; set; }
        public static string Q1C { get; set; }
        public static string Q2N { get; set; }
        public static string Q2C { get; set; }

        Studioout SO = null;

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
            if (Selectvideo.VideoID == null) // Checks if VideoID null
            {
                var Selectvideo = new Selectvideo();
                Selectvideo.ShowDialog(this);
            }

            else { }

            if (Selectvideo.VideoID == null) // Checks if VideoID null
            {
                this.Close();
                timer1.Stop();
            }
            VideoTitleLbl.Text = Selectvideo.VideoTitle; // Displays video title
            //
            // Create columns in tables for tempory data storage
            //
            QueTable.Columns.Add("CommentID", typeof(string));
            QueTable.Columns.Add("Name", typeof(string));
            QueTable.Columns.Add("Comment", typeof(string));

            PlayTable.Columns.Add("CommentID", typeof(string));
            PlayTable.Columns.Add("Name", typeof(string));
            PlayTable.Columns.Add("Comment", typeof(string));

            LogTable.Columns.Add("CommentID", typeof(string));
            LogTable.Columns.Add("Name", typeof(string));
            LogTable.Columns.Add("Comment", typeof(string));
            LogTable.Columns.Add("TimeSelected", typeof(string));

            InitTimer();
            //
            // Get video comments data
            //
            var fb = new FacebookClient(Selectpage.PageAccessToken);
            var LiveVideosComments = string.Format(
                    @"{0}/comments?limit=1000&order=reverse_chronological",
                    Selectvideo.VideoID);
            var result = fb.Get(LiveVideosComments);
            string json = result.ToString();
            //
            // Deserialize JSON data
            //
            RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);
            //
            // CommentsDataGridView autosize
            //
            this.CommentsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CommentsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.CommentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // dataGridView text wrap
            //
            this.CommentsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.QueDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.PlayDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            // dataGridView select only one and whole row
            //
            CommentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CommentsDataGridView.MultiSelect = false;
            CommentsDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(CommentsDataGridView_RowPrePaint);
            QueDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            QueDataGridView.MultiSelect = false;
            QueDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(QueDataGridView_RowPrePaint);
            PlayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PlayDataGridView.MultiSelect = false;
            PlayDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(PlayDataGridView_RowPrePaint);

            int i = 0;

            foreach (Datum d in rootobject.data)
            {
                CommentsDataGridView.Rows.Add();
                CommentsDataGridView.Rows[i].Cells[0].Value = d.id;
                CommentsDataGridView.Rows[i].Cells[1].Value = d.from.name;
                CommentsDataGridView.Rows[i++].Cells[2].Value = d.message;
            }

            if (SO == null)
            {
                SO = new Studioout();
                Screen[] screen1 = Screen.AllScreens;
                Rectangle bound1 = screen1[1].Bounds;
                SO.SetBounds(bound1.X, bound1.Y, bound1.Width, bound1.Height);
                SO.StartPosition = FormStartPosition.Manual;
                SO.Show();
            }
        }

        private System.Windows.Forms.Timer timer1;
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 30000; // in miliseconds
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Selectvideo.VideoID == null)
            {
                timer1.Stop();
            }

            else
            {
                timer1.Interval = 30000; // in miliseconds
                //
                // Get video comments data
                //
                var fb = new FacebookClient(Selectpage.PageAccessToken);
                var LiveVideosComments = string.Format(
                        @"{0}/comments?limit=1000&order=reverse_chronological",
                        Selectvideo.VideoID);
                var result = fb.Get(LiveVideosComments);

                string json = result.ToString();
                //
                // Deserialize JSON data
                //
                RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);

                int i = 0;

                CommentsDataGridView.Rows.Clear();
                foreach (Datum d in rootobject.data)
                {
                    CommentsDataGridView.Rows.Add();
                    CommentsDataGridView.Rows[i].Cells[0].Value = d.id;
                    CommentsDataGridView.Rows[i].Cells[1].Value = d.from.name;
                    CommentsDataGridView.Rows[i++].Cells[2].Value = d.message;
                }
            }
        }

        private void CommentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Interval = 60000; // in miliseconds
        }

        private void SelBtn_Click(object sender, EventArgs e)
        {
            int c1 = CommentsDataGridView.SelectedRows.Count;
            if (c1 > 0) // Checks if a comment has been selected
            {
                string cc = CommentsDataGridView.SelectedCells[2].Value.ToString();
                if (cc.Length > 170) // Checks if comment under 170 characters
                {
                    System.Windows.Forms.MessageBox.Show("Comment not added. Comment is over 170 characters.", "Information");
                }

                else
                {
                    bool exists = LogTable.Select().ToList().Exists(row => row["CommentID"].ToString().ToUpper() == CommentsDataGridView.SelectedCells[0].Value.ToString());

                    if (exists == true) // Check if comment already used.
                    { System.Windows.Forms.MessageBox.Show("Comment has already been used.", "Information"); }

                    else
                    {

                        int c3 = PlayDataGridView.SelectedRows.Count;

                        if (c3 > 0) // Checks if play next has comment
                        {
                            QueTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value); // Add to que table
                            QueDataGridView.DataSource = QueTable;
                            LogTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value, System.DateTime.Now.ToLongTimeString()); // Add to log table
                            //
                            // Autosize
                            //
                            this.QueDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            this.QueDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            QueDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                            //
                            // Hide CommentID from datagridview view
                            //
                            QueDataGridView.Columns[0].Visible = false;
                            //
                            // Refresh CommentsDataGridView
                            //
                            timer1.Interval = 1; // in miliseconds
                            //
                            // Output details to Studioout form
                            //
                            Q1N = PlayDataGridView.Rows[0].Cells[1].Value.ToString();
                            Q1C = PlayDataGridView.Rows[0].Cells[2].Value.ToString();
                            Q2N = QueDataGridView.Rows[0].Cells[1].Value.ToString();
                            Q2C = QueDataGridView.Rows[0].Cells[2].Value.ToString();
                        }

                        else
                        {
                            PlayTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value); // Add to play table
                            PlayDataGridView.DataSource = PlayTable;
                            LogTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value, System.DateTime.Now.ToLongTimeString()); // Add to log table
                            // Autosize
                            //
                            this.PlayDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            this.PlayDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            PlayDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                            PlayDataGridView.Columns[0].Visible = false; // Hide CommentID from datagridview view

                            string name = PlayDataGridView.Rows[0].Cells[1].Value.ToString();
                            string comment = PlayDataGridView.Rows[0].Cells[2].Value.ToString();

                            outputXmL(name, comment);

                            Thread.Sleep(500); // in miliseconds
                            String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";

                            sendastring(V5);
                            current_still = next_still;
                            //
                            // Refresh CommentsDataGridView
                            //
                            timer1.Interval = 1; // in miliseconds
                            //
                            // Output details to Studioout form
                            //
                            Q1N = PlayDataGridView.Rows[0].Cells[1].Value.ToString();
                            Q1C = PlayDataGridView.Rows[0].Cells[2].Value.ToString();
                        }
                    }
                }
            }
            else { System.Windows.Forms.MessageBox.Show("No comment selected.", "Information"); }
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            //
            // Refresh CommentsDataGridView
            //
            timer1.Interval = 1; // in miliseconds
        }

        private void PlyBtn_Click(object sender, EventArgs e)
        {
            int c3 = PlayDataGridView.SelectedRows.Count;
            if (c3 > 0)  // Checks if play has comment
            {
                String V6;

                V6 = @"V\6\1\1\\" + "\r\n"; // Play graphic

                Byte[] data_response = new Byte[256];

                Thread.Sleep(100); // in miliseconds

                sendastring(V6);
                Thread.Sleep(500); // in miliseconds

                foreach (DataGridViewRow row in PlayDataGridView.SelectedRows) // Delete comment from view
                {
                    if (!row.IsNewRow)
                        PlayDataGridView.Rows.Remove(row);
                }

                int c2 = QueDataGridView.SelectedRows.Count;
                if (c2 > 0) // Checks if que next has comment
                {

                    string name = QueDataGridView.Rows[0].Cells[1].Value.ToString();
                    string comment = QueDataGridView.Rows[0].Cells[2].Value.ToString();

                    outputXmL(name, comment);

                    Thread.Sleep(500); // in miliseconds
                    //
                    // Load next comment from que
                    //
                    QueDataGridView.Rows[0].Selected = true;
                    PlayTable.Rows.Add(QueDataGridView.SelectedCells[0].Value, QueDataGridView.SelectedCells[1].Value, QueDataGridView.SelectedCells[2].Value);
                    PlayDataGridView.DataSource = PlayTable;
                    //
                    // Autosize
                    //
                    this.PlayDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.PlayDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    PlayDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    PlayDataGridView.Columns[0].Visible = false; // Hide CommentID from datagridview view

                    foreach (DataGridViewRow row in QueDataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow)
                            QueDataGridView.Rows.Remove(row);
                    }

                    String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";

                    sendastring(V5);
                    current_still = next_still;

                    Q1N = PlayDataGridView.Rows[0].Cells[1].Value.ToString();
                    Q1C = PlayDataGridView.Rows[0].Cells[2].Value.ToString();

                    int c4 = QueDataGridView.SelectedRows.Count;

                    if (c4 < 1) // Checks if que has more than 1 comment remaining
                    {
                        Q2N = null;
                        Q2C = null;
                    }

                    else
                    {
                        //
                        // Output details to Studioout form
                        //    
                        Q2N = QueDataGridView.Rows[0].Cells[1].Value.ToString();
                        Q2C = QueDataGridView.Rows[0].Cells[2].Value.ToString();
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No comment to play.", "Information");
            }
        }

        private void Videocomments_Closing(object sender, FormClosingEventArgs e)
        {
            ////
            //// Write log file
            ////
            //string date = System.DateTime.Now.ToShortDateString().Replace("/", "-");
            //string filename = @"Logs\" + date + " " + VideoTitleLbl.Text + ".xml";
            //DataTable dT = LogTable;
            //DataSet dS = new DataSet();
            //dS.Tables.Add(dT);
            //dS.WriteXml(File.OpenWrite(filename));

            //
            // Clear and close Studioout form
            //
            Q1N = null;
            Q1C = null;
            Q2N = null;
            Q2C = null;
            SO.Close();
            SO = null;
        }
    }
}