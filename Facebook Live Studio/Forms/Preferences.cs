using System;
using System.Configuration;
using System.Windows.Forms;

namespace Live_Studio.Forms
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        public string ComRefTime
        {
            get
            {
                return ConfigurationManager.AppSettings["ComRefTime"];
            }
        }

        public string ComHoldTime
        {
            get
            {
                return ConfigurationManager.AppSettings["ComHoldTime"];
            }
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            ComRefSec.Text = ComRefTime;
            ComHoldSec.Text = ComHoldTime;
        }

        private void CnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SavBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Save Configuration", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["ComRefTime"].Value = ComRefSec.Text;
                config.AppSettings.Settings["ComHoldTime"].Value = ComHoldSec.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
