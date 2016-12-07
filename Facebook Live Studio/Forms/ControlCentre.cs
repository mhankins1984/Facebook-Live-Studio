using System;
using System.Windows.Forms;

namespace Facebook_Live_Studio.Forms
{
    public partial class ControlCentre : Form
    {
        public ControlCentre()
        {
            InitializeComponent();
        }

        private void ControlCentre_Load(object sender, EventArgs e)
        {

        }

        private void AuthoriseButton_Click(object sender, EventArgs e)
        {
            var Authorise = new Authorise();
            Authorise.ShowDialog(this);
        }

        private void Schedulelivevideo_Click(object sender, EventArgs e)
        {
            var Schedulelivevideo = new Schedulelivevideo();
            Schedulelivevideo.ShowDialog(this);
        }

        private void VideocommentsButton_Click(object sender, EventArgs e)
        {
            var Comments = new Videocomments();
            Comments.ShowDialog(this);
        }
    }
}