﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Studio.Forms
{
    public partial class Streampreview : Form
    {
        public Streampreview()
        {
            InitializeComponent();
        }

        private void Videopreview_Load(object sender, EventArgs e)
        {
            if (Selectvideo.VideoID == null) // Checks if VideoID null
            {
                var Selectvideo = new Selectvideo();
                Selectvideo.ShowDialog(this);
            }

            else { }
        }
    }
}
