using System;
using System.Configuration;
using System.Windows.Forms;
using Facebook;
using System.Drawing;

namespace Facebook_Live_Studio.Forms
{
    public partial class Schedulelivevideo : Form
    {

        public Schedulelivevideo()
        {
            InitializeComponent();
            VideoTitleTextBox.ForeColor = SystemColors.GrayText;
            VideotagsTextBox.ForeColor = SystemColors.GrayText;
            VideoTitleTextBox.Text = "Add a title";
            VideotagsTextBox.Text = "Add tags (e.g.football, cats, etc.)";
            VideoTitleTextBox.Leave += new System.EventHandler(this.VideoTitleTextBox_Leave);
            VideoTitleTextBox.Enter += new System.EventHandler(this.VideoTitleTextBox_Enter);
            VideotagsTextBox.Leave += new System.EventHandler(this.VideotagsTextBox_Leave);
            VideotagsTextBox.Enter += new System.EventHandler(this.VideotagsTextBox_Enter);
            //
            // Set facebook date and time limits
            //
            TimePicker.MinDate = System.DateTime.Now.AddMinutes(15);
            TimePicker.Value = System.DateTime.Now.AddMinutes(15);
            DatePicker.Value = System.DateTime.Now.AddMinutes(15);
            DatePicker.MinDate = System.DateTime.Now.AddMinutes(15);
            DatePicker.MaxDate = System.DateTime.Now.AddDays(7);
        }
        //
        // Get required app.config values
        //
        public string PageId
        {
            get
            {
                return ConfigurationManager.AppSettings["PageId"];
            }
        }

        public static string VideoId { get; set; }

        private void Createlivevideo_Load(object sender, EventArgs e)
        {
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "HH:mm";
            TimePicker.ShowUpDown = true;
            TimePicker.Value = System.DateTime.Now.AddMinutes(10);
            DatePicker.MinDate = System.DateTime.Now;

            DateTime date = DatePicker.Value.Date;
            TimeSpan time = TimePicker.Value.TimeOfDay;
            DateTime combined = date.Add(time);

            TimePicker.Value = combined;
            DatePicker.Value = combined;
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

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DatePicker.Value.Date;
            TimeSpan time = TimePicker.Value.TimeOfDay;
            DateTime combined = date.Add(time);

            var controltime = System.DateTime.Now.AddMinutes(15);

            if (combined < controltime)
            {
                TimePicker.Value = System.DateTime.Now.AddMinutes(15);
                System.Windows.Forms.MessageBox.Show("Scheduled live videos must be scheduled between 15 minutes and 7 days (168 hours) from when you create them.", "Information");
            }
                
            else
            {
                TimePicker.Value = combined;
            }
                   
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DatePicker.Value.Date;
            TimeSpan time = TimePicker.Value.TimeOfDay;
            DateTime combined = date.Add(time);

            var controltime = System.DateTime.Now.AddMinutes(15);
            var controldate = System.DateTime.Now.AddDays(7);

            if (combined > controltime)
            {
                if (combined < controldate)
                {
                    DatePicker.Value = combined;
                }

                else
                {
                    System.Windows.Forms.MessageBox.Show("Scheduled live videos must be scheduled between 15 minutes and 7 days (168 hours) from when you create them.", "Information");
                }
            }          
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            //
            // Schedule live
            //
            var dateTime = (DatePicker.Value.Date + TimePicker.Value.TimeOfDay);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (dateTime.ToUniversalTime() - epoch).TotalSeconds;

            var fb = new FacebookClient(Authorise.PageAccessToken);
            var PageLiveVideos = string.Format(
                @"{0}/live_videos",
                this.PageId);
            dynamic result = fb.Post(PageLiveVideos, new { published = false });

            VideoId = result.id;

            var fbupdate = new FacebookClient(Authorise.PageAccessToken);

            fbupdate.Post(VideoId, new { title = VideoTitleTextBox.Text });
            fbupdate.Post(VideoId, new { description = VideoDescriptionTextBox.Text });
            fbupdate.Post(VideoId, new { planned_start_time = unixDateTime });

            var stream_key = result.stream_url.Replace("rtmp://rtmp-api.facebook.com:80/rtmp/", "");
            StreamkeyTextBox.Text = stream_key;
        }
    }
}