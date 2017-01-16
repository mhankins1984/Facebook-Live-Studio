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
using System.Drawing;

namespace Live_Studio.Forms
{
    public partial class Videocomments : Form
    {
        public Videocomments()
        {
            InitializeComponent();
        }

        public string ChyronServer
        {
            get
            {
                return ConfigurationManager.AppSettings["ChyronServer"];
            }
        }
        public string ComRefTime
        {
            get
            {
                return ConfigurationManager.AppSettings["ComRefTime"];
            }
        }
        public string ComHoldTime
        {
            get
            {
                return ConfigurationManager.AppSettings["ComHoldTime"];
            }
        }
        string server;

        private void CommentsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void QueDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void PreviewDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void LiveDataGridVie_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        DataTable QueTable = new DataTable();
        DataTable PreviewTable = new DataTable();
        DataTable LiveTable = new DataTable();
        DataTable LogTable = new DataTable();

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

        public static string Q1N { get; set; }
        public static string Q1C { get; set; }
        public static string Q2N { get; set; }
        public static string Q2C { get; set; }
        public static string Live { get; set; }

        Studioout SO = null;

        void sendastring(String w)
        {
            Debug.WriteLine(String.Format("Chyron Server : {0}", ChyronServer));
            server = ChyronServer;
            Int32 port = 23;
            TcpClient client = new TcpClient(server, port);
            Debug.WriteLine(String.Format("Chyron Server : {0}", client.Client.RemoteEndPoint));

            NetworkStream stream = client.GetStream();

            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(w);
            Debug.WriteLine(data + " Data Length : " + data.Length);

            // Get a client stream for reading and writing.
            Debug.WriteLine(String.Format("Is controlling:{0}, stream read : {1}, write : {2} client connected : {3}", ChyronServer, stream.CanRead, stream.CanWrite, client.Connected));

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
            Cursor.Clip = Screen.PrimaryScreen.Bounds;

            if (Selectvideo.VideoID == null)
            {
                var Selectvideo = new Selectvideo();
                Selectvideo.ShowDialog(this);
            }

            else { }

            if (Selectvideo.VideoID == null)
            {
                this.Close();
                timer1.Stop();
            }
            VideoTitleLbl.Text = Selectvideo.VideoTitle;

            QueTable.Columns.Add("CommentID", typeof(string));
            QueTable.Columns.Add("Name", typeof(string));
            QueTable.Columns.Add("Comment", typeof(string));

            PreviewTable.Columns.Add("CommentID", typeof(string));
            PreviewTable.Columns.Add("Name", typeof(string));
            PreviewTable.Columns.Add("Comment", typeof(string));

            LiveTable.Columns.Add("CommentID", typeof(string));
            LiveTable.Columns.Add("Name", typeof(string));
            LiveTable.Columns.Add("Comment", typeof(string));

            LogTable.Columns.Add("CommentID", typeof(string));
            LogTable.Columns.Add("Name", typeof(string));
            LogTable.Columns.Add("Comment", typeof(string));
            LogTable.Columns.Add("TimeSelected", typeof(string));

            InitTimer();

            var fb = new FacebookClient(Selectpage.PageAccessToken);
            var LiveVideosComments = string.Format(
                    @"{0}/comments?limit=1000&order=reverse_chronological",
                    Selectvideo.VideoID);
            var result = fb.Get(LiveVideosComments);
            string json = result.ToString();

            RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);

            this.CommentsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CommentsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.CommentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.CommentsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.QueDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.PreviewDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.LiveDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            CommentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CommentsDataGridView.MultiSelect = false;
            CommentsDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(CommentsDataGridView_RowPrePaint);
            QueDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            QueDataGridView.MultiSelect = false;
            QueDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(QueDataGridView_RowPrePaint);
            PreviewDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PreviewDataGridView.MultiSelect = false;
            PreviewDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(PreviewDataGridView_RowPrePaint);
            LiveDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LiveDataGridView.MultiSelect = false;
            LiveDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(LiveDataGridVie_RowPrePaint);

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

            QueDataGridView.DataSource = QueTable;
            PreviewDataGridView.DataSource = PreviewTable;
            LiveDataGridView.DataSource = LiveTable;

            this.QueDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QueDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QueDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.PreviewDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PreviewDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PreviewDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.LiveDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LiveDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LiveDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            QueDataGridView.Columns[0].Visible = false;
            PreviewDataGridView.Columns[0].Visible = false;
            LiveDataGridView.Columns[0].Visible = false;
        }

        private System.Windows.Forms.Timer timer1;
        public void InitTimer()
        {
            int stringToInt = Convert.ToInt32(ComRefTime);

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = (1000) * stringToInt;
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Selectvideo.VideoID == null)
            {
                timer1.Stop();
            }

            if (ARCheck.Checked == false)
            {
                timer1.Stop();
            }

            else
            {
                timer1.Start();

                var fb = new FacebookClient(Selectpage.PageAccessToken);
                var LiveVideosComments = string.Format(
                        @"{0}/comments?limit=1000&order=reverse_chronological",
                        Selectvideo.VideoID);
                var result = fb.Get(LiveVideosComments);

                string json = result.ToString();

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

                int stringToInt = Convert.ToInt32(ComRefTime);
                timer1.Interval = (1000) * stringToInt;
            }
        }

        private void CommentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (HCheck.Checked == true)
            {
                int stringToInt = Convert.ToInt32(ComHoldTime);
                timer1.Interval = (1000) * stringToInt;
            }
        }

        private void CommentsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (APCheck.Checked == true)
            {
                int c1 = CommentsDataGridView.SelectedRows.Count;
                if (c1 > 0)
                {
                    string cc = CommentsDataGridView.SelectedCells[2].Value.ToString();
                    if (cc.Length > 170)
                    {
                        System.Windows.Forms.MessageBox.Show("Comment not added. Comment is over 170 characters.", "Information");
                    }

                    else
                    {
                        bool exists = LogTable.Select().ToList().Exists(row => row["CommentID"].ToString().ToUpper() == CommentsDataGridView.SelectedCells[0].Value.ToString());

                        if (exists == true)
                        { System.Windows.Forms.MessageBox.Show("Comment has already been used.", "Information"); }

                        else
                        {

                            int c2 = PreviewDataGridView.SelectedRows.Count;

                            if (c2 > 0)
                            {
                                QueTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value); // Add to que table
                                LogTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value, System.DateTime.Now.ToLongTimeString()); // Add to log table

                                var fb = new FacebookClient(Selectpage.PageAccessToken);
                                var LiveVideosComments = string.Format(
                                        @"{0}/comments?limit=1000&order=reverse_chronological",
                                        Selectvideo.VideoID);
                                var result = fb.Get(LiveVideosComments);

                                string json = result.ToString();

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

                            else
                            {
                                PreviewTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value); // Add to play table
                                LogTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value, System.DateTime.Now.ToLongTimeString()); // Add to log table

                                string name = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                                string comment = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();

                                outputXmL(name, comment);

                                Thread.Sleep(500);
                                String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";

                                sendastring(V5);

                                var fb = new FacebookClient(Selectpage.PageAccessToken);
                                var LiveVideosComments = string.Format(
                                        @"{0}/comments?limit=1000&order=reverse_chronological",
                                        Selectvideo.VideoID);
                                var result = fb.Get(LiveVideosComments);

                                string json = result.ToString();

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

                                Q2N = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                                Q2C = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();
                            }
                        }
                    }
                }
            }

            else
            {
                int c1 = CommentsDataGridView.SelectedRows.Count;
                if (c1 > 0)
                {
                    string cc = CommentsDataGridView.SelectedCells[2].Value.ToString();
                    if (cc.Length > 170)
                    {
                        System.Windows.Forms.MessageBox.Show("Comment not added. Comment is over 170 characters.", "Information");
                    }

                    else
                    {
                        bool exists = LogTable.Select().ToList().Exists(row => row["CommentID"].ToString().ToUpper() == CommentsDataGridView.SelectedCells[0].Value.ToString());

                        if (exists == true)
                        { System.Windows.Forms.MessageBox.Show("Comment has already been used.", "Information"); }

                        else
                        {
                            QueTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value); // Add to que table
                            LogTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value, System.DateTime.Now.ToLongTimeString()); // Add to log table
                                                                                                                                                                                                                              
                            var fb = new FacebookClient(Selectpage.PageAccessToken);
                            var LiveVideosComments = string.Format(
                                    @"{0}/comments?limit=1000&order=reverse_chronological",
                                    Selectvideo.VideoID);
                            var result = fb.Get(LiveVideosComments);

                            string json = result.ToString();

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
                }
                else { System.Windows.Forms.MessageBox.Show("No comment selected.", "Information"); }
            }
        }

        private void SelBtn_Click(object sender, EventArgs e)
        {
            if (APCheck.Checked == true)
            {
                int c1 = CommentsDataGridView.SelectedRows.Count;
                if (c1 > 0)
                {
                    string cc = CommentsDataGridView.SelectedCells[2].Value.ToString();
                    if (cc.Length > 170)
                    {
                        System.Windows.Forms.MessageBox.Show("Comment not added. Comment is over 170 characters.", "Information");
                    }

                    else
                    {
                        bool exists = LogTable.Select().ToList().Exists(row => row["CommentID"].ToString().ToUpper() == CommentsDataGridView.SelectedCells[0].Value.ToString());

                        if (exists == true)
                        { System.Windows.Forms.MessageBox.Show("Comment has already been used.", "Information"); }

                        else
                        {

                            int c2 = PreviewDataGridView.SelectedRows.Count;

                            if (c2 > 0)
                            {
                                QueTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value); // Add to que table
                                LogTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value, System.DateTime.Now.ToLongTimeString()); // Add to log table

                                var fb = new FacebookClient(Selectpage.PageAccessToken);
                                var LiveVideosComments = string.Format(
                                        @"{0}/comments?limit=1000&order=reverse_chronological",
                                        Selectvideo.VideoID);
                                var result = fb.Get(LiveVideosComments);

                                string json = result.ToString();

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

                            else
                            {
                                PreviewTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value); // Add to play table
                                LogTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value, System.DateTime.Now.ToLongTimeString()); // Add to log table

                                string name = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                                string comment = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();

                                outputXmL(name, comment);

                                Thread.Sleep(500);
                                String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";

                                sendastring(V5);

                                var fb = new FacebookClient(Selectpage.PageAccessToken);
                                var LiveVideosComments = string.Format(
                                        @"{0}/comments?limit=1000&order=reverse_chronological",
                                        Selectvideo.VideoID);
                                var result = fb.Get(LiveVideosComments);

                                string json = result.ToString();

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

                                Q2N = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                                Q2C = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();
                            }
                        }
                    }
                }
            }

            else
            {
                int c1 = CommentsDataGridView.SelectedRows.Count;
                if (c1 > 0)
                {
                    string cc = CommentsDataGridView.SelectedCells[2].Value.ToString();
                    if (cc.Length > 170)
                    {
                        System.Windows.Forms.MessageBox.Show("Comment not added. Comment is over 170 characters.", "Information");
                    }

                    else
                    {
                        bool exists = LogTable.Select().ToList().Exists(row => row["CommentID"].ToString().ToUpper() == CommentsDataGridView.SelectedCells[0].Value.ToString());

                        if (exists == true)
                        { System.Windows.Forms.MessageBox.Show("Comment has already been used.", "Information"); }

                        else
                        {
                            QueTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value); // Add to que table
                            LogTable.Rows.Add(CommentsDataGridView.SelectedCells[0].Value, CommentsDataGridView.SelectedCells[1].Value, CommentsDataGridView.SelectedCells[2].Value, System.DateTime.Now.ToLongTimeString()); // Add to log table
                               
                            var fb = new FacebookClient(Selectpage.PageAccessToken);
                            var LiveVideosComments = string.Format(
                                    @"{0}/comments?limit=1000&order=reverse_chronological",
                                    Selectvideo.VideoID);
                            var result = fb.Get(LiveVideosComments);

                            string json = result.ToString();

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
                }

                else { System.Windows.Forms.MessageBox.Show("No comment selected.", "Information"); }
            }
        }

        private void RefBtn_Click(object sender, EventArgs e)
        {
            var fb = new FacebookClient(Selectpage.PageAccessToken);
            var LiveVideosComments = string.Format(
                    @"{0}/comments?limit=1000&order=reverse_chronological",
                    Selectvideo.VideoID);
            var result = fb.Get(LiveVideosComments);

            string json = result.ToString();

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

        private void QueDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (APCheck.Checked == true)
            { System.Windows.Forms.MessageBox.Show("Auto Preview enabled.", "Information"); }

            if (APCheck.Checked == false)
            {
                int c1 = PreviewDataGridView.SelectedRows.Count;

                if (c1 < 1) // Checks if preview has existing
                {
                    PreviewTable.Rows.Add(QueDataGridView.SelectedCells[0].Value, QueDataGridView.SelectedCells[1].Value, QueDataGridView.SelectedCells[2].Value); // Add to que table
                    PreviewDataGridView.DataSource = PreviewTable;

                    if (QCCheck.Checked == true)
                    {
                        foreach (DataGridViewRow row in QueDataGridView.SelectedRows)
                        {
                            if (!row.IsNewRow)
                                QueDataGridView.Rows.Remove(row);
                        }
                    }

                    Q2N = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                    Q2C = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();

                    string name = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                    string comment = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();

                    outputXmL(name, comment);

                    Thread.Sleep(500); // in miliseconds
                    String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";

                    sendastring(V5);
                }
                else { System.Windows.Forms.MessageBox.Show("Exisitng comment in Preview.", "Information"); }
            }
        }

        private void RemBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in QueDataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                    QueDataGridView.Rows.Remove(row);
            }
        }

        private void PlyBtn_Click(object sender, EventArgs e)
        {
            // APCHECK START
            if (APCheck.Checked == true)
            {
                {
                    String V6;
                    V6 = @"V\6\1\1\\" + "\r\n";
                    Byte[] data_response = new Byte[256];
                    Thread.Sleep(100);
                    sendastring(V6);

                    int c1 = PreviewDataGridView.Rows.Count;

                    if (c1 > 0)
                    {
                        foreach (DataGridViewRow row in LiveDataGridView.SelectedRows)
                        {
                            if (!row.IsNewRow)
                                LiveDataGridView.Rows.Remove(row);
                        }

                        LiveTable.Rows.Add(PreviewDataGridView.Rows[0].Cells[0].Value, PreviewDataGridView.Rows[0].Cells[1].Value, PreviewDataGridView.Rows[0].Cells[2].Value); // Add to play table
                        LiveDataGridView.DataSource = LiveTable;

                        Q1N = LiveDataGridView.Rows[0].Cells[1].Value.ToString();
                        Q1C = LiveDataGridView.Rows[0].Cells[2].Value.ToString();
                        Live = "LIVE";

                        foreach (DataGridViewRow row in PreviewDataGridView.SelectedRows)
                        {
                            if (!row.IsNewRow)
                                PreviewDataGridView.Rows.Remove(row);
                        }

                        int c2 = QueDataGridView.Rows.Count;

                        if (c2 > 0)
                        {
                            PreviewTable.Rows.Add(QueDataGridView.Rows[0].Cells[0].Value, QueDataGridView.Rows[0].Cells[1].Value, QueDataGridView.Rows[0].Cells[2].Value); // Add to play table
                            PreviewDataGridView.DataSource = PreviewTable;


                            QueDataGridView.Rows[0].Selected = true;

                            foreach (DataGridViewRow row in QueDataGridView.SelectedRows)
                            {
                                if (!row.IsNewRow)
                                    QueDataGridView.Rows.Remove(row);
                            }
                        }

                        int c3 = PreviewDataGridView.Rows.Count;
                        if (c3 > 0)
                        {
                            Q2N = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                            Q2C = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();
                        }

                        else
                        {
                            Q2N = null;
                            Q2C = null;
                        }
                    }
                    else { System.Windows.Forms.MessageBox.Show("No Comment to Play On.", "Information"); }
                }
            }

            if (APCheck.Checked == false)
            {
                {
                    String V6;
                    V6 = @"V\6\1\1\\" + "\r\n";
                    Byte[] data_response = new Byte[256];
                    Thread.Sleep(100);
                    sendastring(V6);

                    int c1 = PreviewDataGridView.Rows.Count;

                    if (c1 > 0)
                    {
                        foreach (DataGridViewRow row in LiveDataGridView.SelectedRows)
                        {
                            if (!row.IsNewRow)
                                LiveDataGridView.Rows.Remove(row);
                        }

                        LiveTable.Rows.Add(PreviewDataGridView.Rows[0].Cells[0].Value, PreviewDataGridView.Rows[0].Cells[1].Value, PreviewDataGridView.Rows[0].Cells[2].Value); // Add to play table
                        LiveDataGridView.DataSource = LiveTable;

                        Q1N = LiveDataGridView.Rows[0].Cells[1].Value.ToString();
                        Q1C = LiveDataGridView.Rows[0].Cells[2].Value.ToString();
                        Live = "LIVE";

                        foreach (DataGridViewRow row in PreviewDataGridView.SelectedRows)
                        {
                            if (!row.IsNewRow)
                                PreviewDataGridView.Rows.Remove(row);
                        }

                        if (c1 < 0)
                        {
                            Q2N = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                            Q2C = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();
                        }

                        else
                        {
                            Q2N = null;
                            Q2C = null;
                        }
                    }

                    else { System.Windows.Forms.MessageBox.Show("No Comment to Play On.", "Information"); }
                }
            }
        }

        private void PlyoffBtn_Click(object sender, EventArgs e)
        {
            string EffectOut = @"E\EffOut_All\\" + "\r\n";
            sendastring(EffectOut);

            Q1N = null;
            Q1C = null;
            Live = null;

            foreach (DataGridViewRow row in LiveDataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                    LiveDataGridView.Rows.Remove(row);
            }

            int c1 = PreviewDataGridView.Rows.Count;

            if (c1 < 1)
            {
                Q2N = null;
                Q2C = null;
            }

            else
            {
                Q2N = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                Q2C = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();
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

            Q1N = null;
            Q1C = null;
            Q2N = null;
            Q2C = null;
            Live = null;

            if (SO == null)
            {

            }
            else
            {
                SO.Close();
                SO = null;
            }
        }

        private void ManualBtn_Click(object sender, EventArgs e)
        {
            Manualentry Manualentry = new Manualentry(this.QueTable, this.PreviewTable, this.APCheck, this.PreviewDataGridView);
            Manualentry.Show();
        }

        private void APCheck_CheckChanged(object sender, EventArgs e)
        {
            if (APCheck.Checked == true)
            {
                QCCheck.Checked = true;
            }
        }

        private void QCCheck_CheckChanged(object sender, EventArgs e)
        {
            if (QCCheck.Checked == false)
            {
                APCheck.Checked = false;
            }
        }

        private void ARCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ARCheck.Checked == false)
            {
                timer1.Stop();
            }

            if (ARCheck.Checked == true)
            {
                timer1.Start();
            }
        }
    }
}