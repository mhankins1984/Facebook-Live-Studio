using System;
using System.Windows.Forms;

namespace Live_Studio.Forms
{
    public partial class Controlcentre : Form
    {
        public Controlcentre()
        {
            InitializeComponent();
        }

        private void Controlcentre_Load(object sender, EventArgs e)
        {
            var Authorise = new Authorise();
            Authorise.ShowDialog(this);

            if (Authorise.UserAccessToken == null) // Checks if AccessToken null
            {
                this.Close(); // Terminates application if AccessToken null
            }

            this.Show();
            var Selectpage = new Selectpage();
            Selectpage.ShowDialog(this);

            PageNameLbl.Text = Selectpage.PageTitle; // Displays page name            
        }

        private void Schedulelive_Click(object sender, EventArgs e)
        {
            var Schedulelive = new Schedulelive();
            Schedulelive.ShowDialog(this);
        }

        private void ComBtn_Click(object sender, EventArgs e)
        {
            var Videocomments = new Videocomments();
            Videocomments.ShowDialog(this);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            var Selectvideo = new Selectvideo();
            Selectvideo.ShowDialog(this);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Not currently enabled.", "Information");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            var Selectpage = new Selectpage();
            Selectpage.ShowDialog(this);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            var Golive = new Golive();
            Golive.ShowDialog(this);
        }

        private void systemConfigurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var SystemConfiguration = new SystemConfiguration();
            SystemConfiguration.ShowDialog(this);
        }

        private void systemConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Preferences = new Preferences();
            Preferences.ShowDialog(this);
        }

        private void LviBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Not currently enabled.", "Information");
        }
    }
}