using System;
using System.Windows.Forms;
//
// required using
//

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        // OBS JSON Classes
        //
        public class Settings
        {
            public string key { get; set; }
            public string server { get; set; }
            public string service { get; set; }
            public bool show_all { get; set; }
        }

        public class RootObject
        {
            public Settings settings { get; set; }
            public string type { get; set; }
        }

        //
        //
        //

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {

        }


        }
    }
    
}
