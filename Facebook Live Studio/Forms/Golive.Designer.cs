namespace Facebook_Live_Studio.Forms
{
    partial class Golive
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.VideoDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.VideoTitleLabel = new System.Windows.Forms.Label();
            this.VideotagsLabel = new System.Windows.Forms.Label();
            this.VideotagsTextBox = new System.Windows.Forms.TextBox();
            this.VideoTitleTextBox = new System.Windows.Forms.TextBox();
            this.GoliveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.VideoDescriptionTextBox);
            this.panel1.Controls.Add(this.VideoTitleLabel);
            this.panel1.Controls.Add(this.VideotagsLabel);
            this.panel1.Controls.Add(this.VideotagsTextBox);
            this.panel1.Controls.Add(this.VideoTitleTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 332);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Video description";
            // 
            // VideoDescriptionTextBox
            // 
            this.VideoDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoDescriptionTextBox.Location = new System.Drawing.Point(25, 122);
            this.VideoDescriptionTextBox.Multiline = true;
            this.VideoDescriptionTextBox.Name = "VideoDescriptionTextBox";
            this.VideoDescriptionTextBox.Size = new System.Drawing.Size(250, 168);
            this.VideoDescriptionTextBox.TabIndex = 2;
            // 
            // VideoTitleLabel
            // 
            this.VideoTitleLabel.AutoSize = true;
            this.VideoTitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.VideoTitleLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitleLabel.Location = new System.Drawing.Point(22, 12);
            this.VideoTitleLabel.Name = "VideoTitleLabel";
            this.VideoTitleLabel.Size = new System.Drawing.Size(66, 14);
            this.VideoTitleLabel.TabIndex = 5;
            this.VideoTitleLabel.Text = "Video Title";
            // 
            // VideotagsLabel
            // 
            this.VideotagsLabel.AutoSize = true;
            this.VideotagsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.VideotagsLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideotagsLabel.Location = new System.Drawing.Point(22, 56);
            this.VideotagsLabel.Name = "VideotagsLabel";
            this.VideotagsLabel.Size = new System.Drawing.Size(66, 14);
            this.VideotagsLabel.TabIndex = 4;
            this.VideotagsLabel.Text = "Video tags";
            // 
            // VideotagsTextBox
            // 
            this.VideotagsTextBox.BackColor = System.Drawing.Color.White;
            this.VideotagsTextBox.Font = new System.Drawing.Font("Arial", 8F);
            this.VideotagsTextBox.Location = new System.Drawing.Point(25, 73);
            this.VideotagsTextBox.Name = "VideotagsTextBox";
            this.VideotagsTextBox.Size = new System.Drawing.Size(250, 20);
            this.VideotagsTextBox.TabIndex = 1;
            // 
            // VideoTitleTextBox
            // 
            this.VideoTitleTextBox.BackColor = System.Drawing.Color.White;
            this.VideoTitleTextBox.Font = new System.Drawing.Font("Arial", 8F);
            this.VideoTitleTextBox.Location = new System.Drawing.Point(25, 29);
            this.VideoTitleTextBox.Name = "VideoTitleTextBox";
            this.VideoTitleTextBox.Size = new System.Drawing.Size(250, 20);
            this.VideoTitleTextBox.TabIndex = 0;
            // 
            // GoliveButton
            // 
            this.GoliveButton.Location = new System.Drawing.Point(247, 350);
            this.GoliveButton.Name = "GoliveButton";
            this.GoliveButton.Size = new System.Drawing.Size(75, 23);
            this.GoliveButton.TabIndex = 6;
            this.GoliveButton.Text = "Go Live";
            this.GoliveButton.UseVisualStyleBackColor = true;
            this.GoliveButton.Click += new System.EventHandler(this.GoliveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 349);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Golive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 384);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.GoliveButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(350, 418);
            this.MinimumSize = new System.Drawing.Size(350, 418);
            this.Name = "Golive";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Go Live";
            this.Load += new System.EventHandler(this.Golive_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VideoDescriptionTextBox;
        private System.Windows.Forms.Label VideoTitleLabel;
        private System.Windows.Forms.Label VideotagsLabel;
        private System.Windows.Forms.TextBox VideotagsTextBox;
        private System.Windows.Forms.TextBox VideoTitleTextBox;
        private System.Windows.Forms.Button GoliveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}