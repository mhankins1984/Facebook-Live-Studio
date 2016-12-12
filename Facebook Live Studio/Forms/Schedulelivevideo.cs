using System;
using System.Configuration;
using System.Windows.Forms;
using Facebook;
using System.Drawing;

namespace Facebook_Live_Studio.Forms
{
    public partial class Schedulelivevideo : Form
    {
        public string PageId
        {
            get
            {
                return ConfigurationManager.AppSettings["PageId"];
            }
        }

        public Schedulelivevideo()
        {
            InitializeComponent();
            VideoTitleTextBox.ForeColor = SystemColors.GrayText;
            VideotagsTextBox.ForeColor = SystemColors.GrayText;
            VideoTitleTextBox.Text = "Add a title";
            VideotagsTextBox.Text = "Add tags (e.g.football, cats, etc.)";
            this.VideoTitleTextBox.Leave += new System.EventHandler(this.VideoTitleTextBox_Leave);
            this.VideoTitleTextBox.Enter += new System.EventHandler(this.VideoTitleTextBox_Enter);
            this.VideotagsTextBox.Leave += new System.EventHandler(this.VideotagsTextBox_Leave);
            this.VideotagsTextBox.Enter += new System.EventHandler(this.VideotagsTextBox_Enter);
        }

        public static string VideoId { get; set; }

        private void Createlivevideo_Load(object sender, EventArgs e)
        {
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "HH:mm";
            TimePicker.ShowUpDown = true;
            //
            // start live stream
            //
            var fb = new FacebookClient(Authorise.PageAccessToken);
            var PageLiveVideos = string.Format(
                @"{0}/live_videos",
                this.PageId);
            dynamic result = fb.Post(PageLiveVideos, new { published = false });

            var stream_key = result.stream_url.Replace("rtmp://rtmp-api.facebook.com:80/rtmp/", "");
            StreamkeyTextBox.Text = stream_key;

            VideoId = result.id;
           
        }

        private void VideoTitleTextBox_Leave(object sender, EventArgs e)
        {
            if (VideoTitleTextBox.Text.Length == 0)
            {
                VideoTitleTextBox.Text = "Add a title";
                VideoTitleTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void VideoTitleTextBox_Enter(object sender, EventArgs e)
        {
            if (VideoTitleTextBox.Text == "Add a title")
            {
                VideoTitleTextBox.Text = "";
                VideoTitleTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void VideotagsTextBox_Leave(object sender, EventArgs e)
        {
            if (VideotagsTextBox.Text.Length == 0)
            {
                VideotagsTextBox.Text = "Add tags (e.g.football, cats, etc.)";
                VideotagsTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void VideotagsTextBox_Enter(object sender, EventArgs e)
        {
            if (VideotagsTextBox.Text == "Add tags (e.g.football, cats, etc.)")
            {
                VideotagsTextBox.Text = "";
                VideotagsTextBox.ForeColor = SystemColors.WindowText;
            }
        }
        //
        // update stream details
        //
        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            var dateTime = (DatePicker.Value.Date + TimePicker.Value.TimeOfDay);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (dateTime.ToUniversalTime() - epoch).TotalSeconds;
            var fb = new FacebookClient(Authorise.PageAccessToken);

            fb.Post(VideoId, new { title = VideoTitleTextBox.Text });
            fb.Post(VideoId, new { description = VideoDescriptionTextBox.Text });
            fb.Post(VideoId, new { planned_start_time = unixDateTime });
        }
    }
}