namespace Facebook_Live_Studio.Forms
{
    partial class ControlCentre
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
            this.AuthoriseButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.VideocommentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthoriseButton
            // 
            this.AuthoriseButton.Location = new System.Drawing.Point(11, 12);
            this.AuthoriseButton.Name = "AuthoriseButton";
            this.AuthoriseButton.Size = new System.Drawing.Size(120, 30);
            this.AuthoriseButton.TabIndex = 0;
            this.AuthoriseButton.Text = "Authorise";
            this.AuthoriseButton.UseVisualStyleBackColor = true;
            this.AuthoriseButton.Click += new System.EventHandler(this.AuthoriseButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(11, 48);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(120, 30);
            this.ScheduleButton.TabIndex = 1;
            this.ScheduleButton.Text = "Schedule live video";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.Schedulelivevideo_Click);
            // 
            // VideocommentsButton
            // 
            this.VideocommentsButton.Location = new System.Drawing.Point(12, 84);
            this.VideocommentsButton.Name = "VideocommentsButton";
            this.VideocommentsButton.Size = new System.Drawing.Size(120, 30);
            this.VideocommentsButton.TabIndex = 2;
            this.VideocommentsButton.Text = "Comments";
            this.VideocommentsButton.UseVisualStyleBackColor = true;
            this.VideocommentsButton.Click += new System.EventHandler(this.VideocommentsButton_Click);
            // 
            // ControlCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 742);
            this.Controls.Add(this.VideocommentsButton);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.AuthoriseButton);
            this.Name = "ControlCentre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Live";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ControlCentre_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AuthoriseButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button VideocommentsButton;
    }
}