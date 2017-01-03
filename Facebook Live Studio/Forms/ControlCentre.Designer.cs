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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PageNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LveBtn = new System.Windows.Forms.Button();
            this.PgeBtn = new System.Windows.Forms.Button();
            this.VidBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 203);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.groupBox1.Location = new System.Drawing.Point(185, 303);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 303);
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
            this.groupBox2.Location = new System.Drawing.Point(99, 230);
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
            this.groupBox4.Location = new System.Drawing.Point(99, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 50);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comment Control";
            // 
            // Controlcentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(364, 462);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controlcentre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "facebook live Studio";
            this.Load += new System.EventHandler(this.Controlcentre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ComBtn;
        private System.Windows.Forms.Button PrvBtn;
        private System.Windows.Forms.Button LviBtn;
        private System.Windows.Forms.Button SchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PageNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button LveBtn;
        private System.Windows.Forms.Button PgeBtn;
        private System.Windows.Forms.Button VidBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}