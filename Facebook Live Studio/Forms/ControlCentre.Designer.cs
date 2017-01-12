namespace Facebook_Live_Studio.Forms
{
    partial class Controlcentre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controlcentre));
            this.ComBtn = new System.Windows.Forms.Button();
            this.PrvBtn = new System.Windows.Forms.Button();
            this.LviBtn = new System.Windows.Forms.Button();
            this.SchBtn = new System.Windows.Forms.Button();
            this.PageNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LveBtn = new System.Windows.Forms.Button();
            this.PgeBtn = new System.Windows.Forms.Button();
            this.VidBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemConfigurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Header = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            this.SuspendLayout();
            // 
            // ComBtn
            // 
            this.ComBtn.ForeColor = System.Drawing.Color.Black;
            this.ComBtn.Location = new System.Drawing.Point(6, 19);
            this.ComBtn.Name = "ComBtn";
            this.ComBtn.Size = new System.Drawing.Size(75, 23);
            this.ComBtn.TabIndex = 4;
            this.ComBtn.Text = "&Comments";
            this.ComBtn.UseVisualStyleBackColor = true;
            this.ComBtn.Click += new System.EventHandler(this.ComBtn_Click);
            // 
            // PrvBtn
            // 
            this.PrvBtn.ForeColor = System.Drawing.Color.Black;
            this.PrvBtn.Location = new System.Drawing.Point(6, 19);
            this.PrvBtn.Name = "PrvBtn";
            this.PrvBtn.Size = new System.Drawing.Size(75, 23);
            this.PrvBtn.TabIndex = 2;
            this.PrvBtn.Text = "Preview";
            this.PrvBtn.UseVisualStyleBackColor = true;
            this.PrvBtn.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // LviBtn
            // 
            this.LviBtn.ForeColor = System.Drawing.Color.Black;
            this.LviBtn.Location = new System.Drawing.Point(86, 19);
            this.LviBtn.Name = "LviBtn";
            this.LviBtn.Size = new System.Drawing.Size(75, 23);
            this.LviBtn.TabIndex = 3;
            this.LviBtn.Text = "Live View";
            this.LviBtn.UseVisualStyleBackColor = true;
            this.LviBtn.Click += new System.EventHandler(this.LviBtn_Click);
            // 
            // SchBtn
            // 
            this.SchBtn.ForeColor = System.Drawing.Color.Black;
            this.SchBtn.Location = new System.Drawing.Point(6, 19);
            this.SchBtn.Name = "SchBtn";
            this.SchBtn.Size = new System.Drawing.Size(75, 23);
            this.SchBtn.TabIndex = 5;
            this.SchBtn.Text = "&Schedule";
            this.SchBtn.UseVisualStyleBackColor = true;
            this.SchBtn.Click += new System.EventHandler(this.Schedulelive_Click);
            // 
            // PageNameLbl
            // 
            this.PageNameLbl.AutoSize = true;
            this.PageNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNameLbl.ForeColor = System.Drawing.Color.White;
            this.PageNameLbl.Location = new System.Drawing.Point(135, 60);
            this.PageNameLbl.Name = "PageNameLbl";
            this.PageNameLbl.Size = new System.Drawing.Size(0, 20);
            this.PageNameLbl.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrvBtn);
            this.groupBox1.Controls.Add(this.LviBtn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(185, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream Views";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LveBtn);
            this.groupBox3.Controls.Add(this.SchBtn);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 50);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Go Live";
            // 
            // LveBtn
            // 
            this.LveBtn.ForeColor = System.Drawing.Color.Black;
            this.LveBtn.Location = new System.Drawing.Point(86, 19);
            this.LveBtn.Name = "LveBtn";
            this.LveBtn.Size = new System.Drawing.Size(75, 23);
            this.LveBtn.TabIndex = 6;
            this.LveBtn.Text = "&Go Live";
            this.LveBtn.UseVisualStyleBackColor = true;
            this.LveBtn.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // PgeBtn
            // 
            this.PgeBtn.ForeColor = System.Drawing.Color.Black;
            this.PgeBtn.Location = new System.Drawing.Point(6, 19);
            this.PgeBtn.Name = "PgeBtn";
            this.PgeBtn.Size = new System.Drawing.Size(75, 23);
            this.PgeBtn.TabIndex = 0;
            this.PgeBtn.Text = "Page";
            this.PgeBtn.UseVisualStyleBackColor = true;
            this.PgeBtn.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // VidBtn
            // 
            this.VidBtn.ForeColor = System.Drawing.Color.Black;
            this.VidBtn.Location = new System.Drawing.Point(86, 19);
            this.VidBtn.Name = "VidBtn";
            this.VidBtn.Size = new System.Drawing.Size(75, 23);
            this.VidBtn.TabIndex = 1;
            this.VidBtn.Text = "Video";
            this.VidBtn.UseVisualStyleBackColor = true;
            this.VidBtn.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VidBtn);
            this.groupBox2.Controls.Add(this.PgeBtn);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(99, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selections";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ComBtn);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(98, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 50);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comment Control";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemConfigurationToolStripMenuItem,
            this.systemConfigurationToolStripMenuItem1});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.configurationToolStripMenuItem.Text = "Settings";
            // 
            // systemConfigurationToolStripMenuItem
            // 
            this.systemConfigurationToolStripMenuItem.Name = "systemConfigurationToolStripMenuItem";
            this.systemConfigurationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.systemConfigurationToolStripMenuItem.Text = "Preferences";
            this.systemConfigurationToolStripMenuItem.Click += new System.EventHandler(this.systemConfigurationToolStripMenuItem_Click);
            // 
            // systemConfigurationToolStripMenuItem1
            // 
            this.systemConfigurationToolStripMenuItem1.Name = "systemConfigurationToolStripMenuItem1";
            this.systemConfigurationToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.systemConfigurationToolStripMenuItem1.Text = "System Configuration";
            this.systemConfigurationToolStripMenuItem1.Click += new System.EventHandler(this.systemConfigurationToolStripMenuItem1_Click);
            // 
            // Header
            // 
            this.Header.Image = ((System.Drawing.Image)(resources.GetObject("Header.Image")));
            this.Header.Location = new System.Drawing.Point(0, 27);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(364, 200);
            this.Header.TabIndex = 14;
            this.Header.TabStop = false;
            // 
            // Controlcentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(364, 462);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageNameLbl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controlcentre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live Studio";
            this.Load += new System.EventHandler(this.Controlcentre_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ComBtn;
        private System.Windows.Forms.Button PrvBtn;
        private System.Windows.Forms.Button LviBtn;
        private System.Windows.Forms.Button SchBtn;
        private System.Windows.Forms.Label PageNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button LveBtn;
        private System.Windows.Forms.Button PgeBtn;
        private System.Windows.Forms.Button VidBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemConfigurationToolStripMenuItem1;
        private System.Windows.Forms.PictureBox Header;
    }
}