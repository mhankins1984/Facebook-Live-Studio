namespace Facebook_Live_Studio.Forms
{
    partial class Studioout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Q2N = new System.Windows.Forms.Label();
            this.Q2C = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.split = new System.Windows.Forms.Label();
            this.Q1N = new System.Windows.Forms.Label();
            this.Q1C = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Q2N
            // 
            this.Q2N.AutoSize = true;
            this.Q2N.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2N.ForeColor = System.Drawing.Color.Yellow;
            this.Q2N.Location = new System.Drawing.Point(0, 578);
            this.Q2N.Name = "Q2N";
            this.Q2N.Size = new System.Drawing.Size(224, 98);
            this.Q2N.TabIndex = 1;
            this.Q2N.Text = "Q2N";
            // 
            // Q2C
            // 
            this.Q2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.Q2C.ForeColor = System.Drawing.Color.White;
            this.Q2C.Location = new System.Drawing.Point(0, 676);
            this.Q2C.Name = "Q2C";
            this.Q2C.Size = new System.Drawing.Size(1920, 400);
            this.Q2C.TabIndex = 5;
            this.Q2C.Text = "Q2C\r\nQ2C\r\nQ2C\r\nQ2C";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // split
            // 
            this.split.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.split.ForeColor = System.Drawing.Color.Red;
            this.split.Location = new System.Drawing.Point(0, 502);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(1920, 76);
            this.split.TabIndex = 6;
            this.split.Text = "---------------------------------------------------------------------------------" +
    "----";
            this.split.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q1N
            // 
            this.Q1N.AutoSize = true;
            this.Q1N.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1N.ForeColor = System.Drawing.Color.Yellow;
            this.Q1N.Location = new System.Drawing.Point(0, 0);
            this.Q1N.Name = "Q1N";
            this.Q1N.Size = new System.Drawing.Size(224, 98);
            this.Q1N.TabIndex = 2;
            this.Q1N.Text = "Q1N";
            // 
            // Q1C
            // 
            this.Q1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.Q1C.ForeColor = System.Drawing.Color.White;
            this.Q1C.Location = new System.Drawing.Point(0, 98);
            this.Q1C.Name = "Q1C";
            this.Q1C.Size = new System.Drawing.Size(1920, 400);
            this.Q1C.TabIndex = 4;
            this.Q1C.Text = "Q1C\r\nQ1C\r\nQ1C\r\nQ1C\r\n";
            // 
            // Studioout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.split);
            this.Controls.Add(this.Q2C);
            this.Controls.Add(this.Q1C);
            this.Controls.Add(this.Q1N);
            this.Controls.Add(this.Q2N);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Studioout";
            this.ShowInTaskbar = false;
            this.Text = "Studio Out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Studioout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Q2N;
        private System.Windows.Forms.Label Q2C;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label split;
        private System.Windows.Forms.Label Q1N;
        private System.Windows.Forms.Label Q1C;
    }
}