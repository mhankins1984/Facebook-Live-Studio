using System;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using Facebook;
using Newtonsoft.Json;

namespace Facebook_Live_Studio.Forms
{
    public partial class Videoselector : Form
    {
        public Videoselector()
        {
            InitializeComponent();
        }
        //
        // Livevideo classes
        //
        public class Datum
        {
            public string title { get; set; }
            public string status { get; set; }
            public string stream_url { get; set; }
            public string secure_stream_url { get; set; }
            public string embed_html { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string planned_start_time { get; set; }
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

        public string PageId
        {
            get
            {
                return ConfigurationManager.AppSettings["PageId"];
            }
        }

        public static string VideoID { get; set; }

        private void Videoselector_Load(object sender, EventArgs e)
        {
            //
            // Get live_video data
            //
            var fb = new FacebookClient(Authorise.PageAccessToken);
            var LiveVideos = string.Format(
                    @"{0}/live_videos",
                    this.PageId);
            var result = fb.Get(LiveVideos);

            string json = result.ToString();
            //
            // Deserialize JSON data
            //
            RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);
            //
            // dataGridView1 autosize
            //
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //
            // dataGridView select whole row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            int i = 0;

            foreach (Datum d in rootobject.data)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = d.id;
                dataGridView1.Rows[i].Cells[1].Value = d.status;
                dataGridView1.Rows[i++].Cells[2].Value = d.title;
             }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            VideoID = dataGridView1.SelectedCells[0].Value.ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VideoID = dataGridView1.SelectedCells[0].Value.ToString();
            //
            // Delete selected video
            //
            var fbdel = new FacebookClient(Authorise.PageAccessToken);
            var delresult = fbdel.Delete(VideoID);
            //
            // Get live_video data
            //
            var fb = new FacebookClient(Authorise.PageAccessToken);
            var LiveVideos = string.Format(
                    @"{0}/live_videos",
                    this.PageId);
            var result = fb.Get(LiveVideos);

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
                dataGridView1.Rows[i].Cells[1].Value = d.status;
                dataGridView1.Rows[i++].Cells[2].Value = d.title;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           this.Close();
            VideoID = null;
        }
    }
}