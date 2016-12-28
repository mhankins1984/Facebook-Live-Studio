using System;
using System.Windows.Forms;
using Facebook;
using System.IO;
using System.Configuration;


namespace Facebook_Live_Studio.Forms
{
    public partial class Golive : Form
    {
        public Golive()
        {
            InitializeComponent();
        }

        public string OBSLocation
        {
            get
            {
                return ConfigurationManager.AppSettings["OBSLocation"];
            }
        }

        public static string VideoId { get; set; }

        private void Golive_Load(object sender, EventArgs e)
        {
            if (Selectpage.PageId == null)
            {
                var Selectpage = new Selectpage();
                Selectpage.ShowDialog(this);
            }
        }
        
        private void GoliveButton_Click(object sender, EventArgs e)
        {
            //
            // Starts live video
            //
            var fb = new FacebookClient(Selectpage.PageAccessToken);
            var PageLiveVideos = string.Format(
                @"{0}/live_videos",
                Selectpage.PageId);
            dynamic result = fb.Post(PageLiveVideos, new { published = false });

            VideoId = result.id;

            var fbupdate = new FacebookClient(Selectpage.PageAccessToken);
            //
            // Adds video detail
            //
            fbupdate.Post(VideoId, new { title = VideoTitleTextBox.Text });
            fbupdate.Post(VideoId, new { description = VideoDescriptionTextBox.Text });
            fbupdate.Post(VideoId, new { status = "LIVE_NOW" });

            Videoselector.VideoID = VideoId; // Sets VideoId to current video
            //
            // Update OBS json file
            //
            var stream_key = result.stream_url.Replace("rtmp://rtmp-api.facebook.com:80/rtmp/", "");
            string json = File.ReadAllText(OBSLocation);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["settings"]["key"] = stream_key;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(OBSLocation, output);

            this.Close(); // close go live form

            var Videocomments = new Videocomments();
            Videocomments.ShowDialog(this); // Open videocomments with current VideoId selected
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
