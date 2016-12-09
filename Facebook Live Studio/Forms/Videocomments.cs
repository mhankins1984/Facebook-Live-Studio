using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Facebook;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;

namespace Facebook_Live_Studio.Forms
{
    public partial class Videocomments : Form
    {

        public Videocomments()
        {
            InitializeComponent();
        }

        int current_still;
        int next_still;
        string server;

        string chyronAddress = "10.176.4.243";

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        DataTable table = new DataTable();

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
            System.IO.StreamWriter sw=new System.IO.StreamWriter(@"\\10.176.4.104\ProjectParking\Election2016XML\ConstituencyXML\feedback.xml");
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

        private void Videocomments_Load(object sender, EventArgs e)
        {
            var Videoselector = new Videoselector();
            Videoselector.ShowDialog(this);


            if (Videoselector.VideoID == null)
            {
                this.Close();
                timer1.Stop();
            }

            else { }

            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Comment", typeof(string));

            InitTimer();
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            // Get video comments data
            //
            var fb = new FacebookClient(Authorise.PageAccessToken);
            var LiveVideosComments = string.Format(
                    @"{0}/comments?order=reverse_chronological",
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
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //
            // dataGridView select whole row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView2_RowPrePaint);

            int i = 0;

            foreach (Datum d in rootobject.data)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = d.from.name;
                dataGridView1.Rows[i++].Cells[1].Value = d.message;
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
                        @"{0}/comments?order=reverse_chronological",
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
                    dataGridView1.Rows[i].Cells[0].Value = d.from.name;
                    dataGridView1.Rows[i++].Cells[1].Value = d.message;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Interval = 30000; // in miliseconds
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[1].Value);
            dataGridView2.DataSource = table;

            //
            // dataGridView2 autosize
            //
            this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1; // in miliseconds
        }

        private void QueButton_Click(object sender, EventArgs e)
        {
            string name = dataGridView2.SelectedCells[0].Value.ToString();
            string comment = dataGridView2.SelectedCells[1].Value.ToString();

            outputXmL(name, comment);

            Thread.Sleep(500);

            String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";

            sendastring(V5);
            current_still = next_still;
        }

        void sendastring(String w)
        {
            Debug.WriteLine(String.Format("Chyron Address : {0}", chyronAddress));
            server = chyronAddress;
            Int32 port = 23;
            TcpClient client = new TcpClient(server, port);
            Debug.WriteLine(String.Format("Chyron Address : {0}", client.Client.RemoteEndPoint));

            NetworkStream stream = client.GetStream();


            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(w);
            Debug.WriteLine(data + " Data Length : " + data.Length);

            // Get a client stream for reading and writing.


            //Thread.Sleep(50);
            Debug.WriteLine(String.Format("Is controlling:{0}, stream read : {1}, write : {2} client connected : {3}", chyronAddress, stream.CanRead, stream.CanWrite, client.Connected));

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

        private void playButton_Click(object sender, EventArgs e)
        {
            String V6;
            //Play
            V6 = @"V\6\1\1\\" + "\r\n";


            Byte[] data_response = new Byte[256];


            Thread.Sleep(100);

            sendastring(V6);
            Thread.Sleep(500);
        }
    }
}