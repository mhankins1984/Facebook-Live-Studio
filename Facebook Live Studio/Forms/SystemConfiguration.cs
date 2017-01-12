using System;
using System.Configuration;
using System.Windows.Forms;

namespace Facebook_Live_Studio.Forms
{
    public partial class SystemConfiguration : Form
    {
        public SystemConfiguration()
        {
            InitializeComponent();
        }

        public string ChyronServer
        {
            get
            {
                return ConfigurationManager.AppSettings["ChyronServer"];
            }
        }

        public string OBSLocation
        {
            get
            {
                return ConfigurationManager.AppSettings["OBSLocation"];
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            ChyronTB.Text = ChyronServer;
            ObsTB.Text = OBSLocation;
            ChyronTB.Select(0, 0);
        }

        private void SavBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Save Configuration", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["ChyronServer"].Value = ChyronTB.Text;
                config.AppSettings.Settings["OBSLocation"].Value = ObsTB.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }


        }

        private void CnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
