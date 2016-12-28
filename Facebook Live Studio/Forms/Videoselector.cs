using System;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using Facebook;
using Newtonsoft.Json;
using System.IO;

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

        public string OBSLocation
        {
            get
            {
                return ConfigurationManager.AppSettings["OBSLocation"];
            }
        }

        public static string VideoID { get; set; }
        public static string VideoTitle { get; set; }

        private void Videoselector_Load(object sender, EventArgs e)
        {
            if (Selectpage.PageId == null)
            {
                var Selectpage = new Selectpage();
                Selectpage.ShowDialog(this);
            }

            else
            {
                //
                // Get live_video data
                //
                var fb = new FacebookClient(Selectpage.PageAccessToken);
                var LiveVideos = string.Format(
                        @"{0}/live_videos",
                        Selectpage.PageId);
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
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //
                // dataGridView select whole row
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;

                int i = 0;

                foreach (Datum d in rootobject.data)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = d.status;
                    dataGridView1.Rows[i].Cells[1].Value = d.title;
                    dataGridView1.Rows[i].Cells[2].Value = d.id;
                    dataGridView1.Rows[i++].Cells[3].Value = d.stream_url.Replace("rtmp://rtmp-api.facebook.com:80/rtmp/", "");
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            //
            // Update OBS json file
            //
            var stream_key = dataGridView1.SelectedCells[3].Value.ToString();
            string json = File.ReadAllText(OBSLocation);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["settings"]["key"] = stream_key;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(OBSLocation, output);
            //
            // Copy videoid and title to public static string
            //
            VideoID = dataGridView1.SelectedCells[2].Value.ToString();
            VideoTitle = dataGridView1.SelectedCells[1].Value.ToString();
            this.Close();
        }        

        private void CancelButton_Click(object sender, EventArgs e)
        {
           this.Close();
           VideoID = null;
        }

        
        private void Videoselector_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}