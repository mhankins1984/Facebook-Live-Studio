using System;
using System.Windows.Forms;
using Facebook;

namespace Facebook_Live_Studio.Forms
{
    public partial class Schedulelive : Form
    {

        public Schedulelive()
        {
            InitializeComponent();
            //
            // Set facebook date and time limits
            //
            TimePicker.MinDate = System.DateTime.Now.AddMinutes(15);
            TimePicker.Value = System.DateTime.Now.AddMinutes(15);
            DatePicker.Value = System.DateTime.Now.AddMinutes(15);
            DatePicker.MinDate = System.DateTime.Now.AddMinutes(15);
            DatePicker.MaxDate = System.DateTime.Now.AddHours(168);
        }
        //
        // Get required app.config values
        //

        public static string VideoId { get; set; }

        private void Createlivevideo_Load(object sender, EventArgs e)
        {
            if (Selectpage.PageId == null)
            {
                var Selectpage = new Selectpage();
                Selectpage.ShowDialog(this);
            }

            else
            {
                //
                // Sets time and date picker formats
                //
                TimePicker.Format = DateTimePickerFormat.Custom;
                TimePicker.CustomFormat = "HH:mm";
                TimePicker.ShowUpDown = true;
                TimePicker.Value = System.DateTime.Now.AddMinutes(10);
                DatePicker.MinDate = System.DateTime.Now;
                //
                // Syncs date and time picker
                //
                DateTime date = DatePicker.Value.Date;
                TimeSpan time = TimePicker.Value.TimeOfDay;
                DateTime combined = date.Add(time);
                TimePicker.Value = combined;
                DatePicker.Value = combined;
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
                    TimePicker.Value = System.DateTime.Now.AddHours(167);
                    DatePicker.Value = System.DateTime.Now.AddHours(167);
                    System.Windows.Forms.MessageBox.Show("Scheduled live videos must be scheduled between 15 minutes and 7 days (168 hours) from when you create them.", "Information");                        
                }
            }          
        }

        private void SchBtn_Click(object sender, EventArgs e)
        {
            //
            // Schedule live
            //
            var dateTime = (DatePicker.Value.Date + TimePicker.Value.TimeOfDay);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (dateTime.ToUniversalTime() - epoch).TotalSeconds;

            var fb = new FacebookClient(Selectpage.PageAccessToken);
            var PageLiveVideos = string.Format(
                @"{0}/live_videos",
                Selectpage.PageId);
            dynamic result = fb.Post(PageLiveVideos, new { published = false });

            VideoId = result.id;

            var fbupdate = new FacebookClient(Selectpage.PageAccessToken);

            fbupdate.Post(VideoId, new { title = VideoTitleTextBox.Text });
            fbupdate.Post(VideoId, new { description = VideoDescriptionTextBox.Text });
            fbupdate.Post(VideoId, new { planned_start_time = unixDateTime });

            var stream_key = result.stream_url.Replace("rtmp://rtmp-api.facebook.com:80/rtmp/", "");
            StreamkeyTextBox.Text = stream_key;
        }

        private void CanBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}