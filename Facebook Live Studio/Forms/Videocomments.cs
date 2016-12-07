using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Facebook;
using Newtonsoft.Json;


namespace Facebook_Live_Studio.Forms
{
    public partial class Videocomments : Form
    {
        private System.Windows.Forms.ListView listView1;

        public Videocomments()
        {
            InitializeComponent();
            InitializeListView();
        }

        public void InitializeListView()
        {
            ColumnHeader header1 = this.listView1.Columns.Add("Name", 20 * Convert.ToInt32(listView1.Font.SizeInPoints), HorizontalAlignment.Center);
            ColumnHeader header2 = this.listView1.Columns.Add("Comment", 80 * Convert.ToInt32(listView1.Font.SizeInPoints), HorizontalAlignment.Center);
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
           InitTimer();

            //
            // deserialize video comments json data
            //
            var fb = new FacebookClient(Authorise.PageAccessToken);
            var LiveVideosComments = string.Format(
                    @"{0}/comments",
                    "111943332627933");
            var result = fb.Get(LiveVideosComments);

            string json = result.ToString();

            RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);

            foreach (Datum d in rootobject.data)
            {
                ListViewItem lvi = new ListViewItem(new string[] { d.from.name, d.message });
                listView1.Items.Add(lvi);
            }
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           timer1.Enabled = true;

            //
            // deserialize video comments json data
            //
            var fb = new FacebookClient(Authorise.PageAccessToken);
            var LiveVideosComments = string.Format(
                    @"{0}/comments",
                    "111943332627933");
            var result = fb.Get(LiveVideosComments);

            string json = result.ToString();

            RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);

            listView1.Items.Clear();
            foreach (Datum d in rootobject.data)
            {
                ListViewItem lvi = new ListViewItem(new string[] { d.from.name, d.message });
                listView1.Items.Add(lvi);
            }
        }

        void outputXmL(string name, string comment)
        {
            ChyronData cd = new ChyronData();

            cd.PageType = "facebook_template_1";
            cd.TemplatePageNumber = "201";
            cd.BuildPageNumber = "1001";
            cd.Name = name;
            cd.Comment = comment;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(cd.GetType());
            x.Serialize(new System.IO.StreamWriter(@"c:\Scripts\text.xml"), cd);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}