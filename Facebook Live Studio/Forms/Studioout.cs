using System;
using System.Windows.Forms;

namespace Facebook_Live_Studio.Forms
{
    public partial class Studioout : Form
    {
        public Studioout()
        {
            InitializeComponent();
        }

        private void Studioout_Load(object sender, EventArgs e)
        {
            Q1N.Text = Videocomments.Q1N;
            Q1C.Text = Videocomments.Q1C;
            Q2N.Text = Videocomments.Q2N;
            Q2C.Text = Videocomments.Q2C;
            Live.Text = Videocomments.Live;           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Q1N.Text = Videocomments.Q1N;
            Q1C.Text = Videocomments.Q1C;
            Q2N.Text = Videocomments.Q2N;
            Q2C.Text = Videocomments.Q2C;
            Live.Text = Videocomments.Live;
        }
    }
}