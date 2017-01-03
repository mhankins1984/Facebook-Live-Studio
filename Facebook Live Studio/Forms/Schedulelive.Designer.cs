namespace Facebook_Live_Studio.Forms
{
    partial class Schedulelive
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
            this.SchBtn = new System.Windows.Forms.Button();
            this.CanBtn = new System.Windows.Forms.Button();
            this.VideoTitleTextBox = new System.Windows.Forms.TextBox();
            this.VideotagsTextBox = new System.Windows.Forms.TextBox();
            this.VideotagsLbl = new System.Windows.Forms.Label();
            this.VideoTitleLbl = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.VideoDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SchBtn
            // 
            this.SchBtn.ForeColor = System.Drawing.Color.Black;
            this.SchBtn.Location = new System.Drawing.Point(247, 368);
            this.SchBtn.Name = "SchBtn";
            this.SchBtn.Size = new System.Drawing.Size(75, 23);
            this.SchBtn.TabIndex = 5;
            this.SchBtn.Text = "&Schedule";
            this.SchBtn.UseVisualStyleBackColor = true;
            this.SchBtn.Click += new System.EventHandler(this.SchBtn_Click);
            // 
            // CanBtn
            // 
            this.CanBtn.ForeColor = System.Drawing.Color.Black;
            this.CanBtn.Location = new System.Drawing.Point(12, 368);
            this.CanBtn.Name = "CanBtn";
            this.CanBtn.Size = new System.Drawing.Size(75, 23);
            this.CanBtn.TabIndex = 6;
            this.CanBtn.Text = "&Cancel";
            this.CanBtn.UseVisualStyleBackColor = true;
            this.CanBtn.Click += new System.EventHandler(this.CanBtn_Click);
            // 
            // VideoTitleTextBox
            // 
            this.VideoTitleTextBox.BackColor = System.Drawing.Color.White;
            this.VideoTitleTextBox.Font = new System.Drawing.Font("Arial", 8F);
            this.VideoTitleTextBox.Location = new System.Drawing.Point(25, 41);
            this.VideoTitleTextBox.Name = "VideoTitleTextBox";
            this.VideoTitleTextBox.Size = new System.Drawing.Size(280, 20);
            this.VideoTitleTextBox.TabIndex = 0;
            // 
            // VideotagsTextBox
            // 
            this.VideotagsTextBox.BackColor = System.Drawing.Color.White;
            this.VideotagsTextBox.Font = new System.Drawing.Font("Arial", 8F);
            this.VideotagsTextBox.Location = new System.Drawing.Point(25, 85);
            this.VideotagsTextBox.Name = "VideotagsTextBox";
            this.VideotagsTextBox.Size = new System.Drawing.Size(280, 20);
            this.VideotagsTextBox.TabIndex = 1;
            // 
            // VideotagsLbl
            // 
            this.VideotagsLbl.AutoSize = true;
            this.VideotagsLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.VideotagsLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideotagsLbl.Location = new System.Drawing.Point(21, 68);
            this.VideotagsLbl.Name = "VideotagsLbl";
            this.VideotagsLbl.Size = new System.Drawing.Size(66, 14);
            this.VideotagsLbl.TabIndex = 4;
            this.VideotagsLbl.Text = "Video tags";
            // 
            // VideoTitleLbl
            // 
            this.VideoTitleLbl.AutoSize = true;
            this.VideoTitleLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.VideoTitleLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitleLbl.ForeColor = System.Drawing.Color.White;
            this.VideoTitleLbl.Location = new System.Drawing.Point(21, 24);
            this.VideoTitleLbl.Name = "VideoTitleLbl";
            this.VideoTitleLbl.Size = new System.Drawing.Size(66, 14);
            this.VideoTitleLbl.TabIndex = 5;
            this.VideoTitleLbl.Text = "Video Title";
            // 
            // TimePicker
            // 
            this.TimePicker.Location = new System.Drawing.Point(198, 330);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(72, 20);
            this.TimePicker.TabIndex = 4;
            this.TimePicker.Value = new System.DateTime(2016, 12, 2, 12, 0, 0, 0);
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // VideoDescriptionTextBox
            // 
            this.VideoDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoDescriptionTextBox.Location = new System.Drawing.Point(25, 134);
            this.VideoDescriptionTextBox.Multiline = true;
            this.VideoDescriptionTextBox.Name = "VideoDescriptionTextBox";
            this.VideoDescriptionTextBox.Size = new System.Drawing.Size(280, 168);
            this.VideoDescriptionTextBox.TabIndex = 2;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(25, 330);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(147, 20);
            this.DatePicker.TabIndex = 3;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(22, 313);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(122, 14);
            this.Lbl1.TabIndex = 8;
            this.Lbl1.Text = "Scheduled start time";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(21, 117);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(105, 14);
            this.Lbl3.TabIndex = 6;
            this.Lbl3.Text = "Video description";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(276, 336);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(29, 14);
            this.Lbl2.TabIndex = 9;
            this.Lbl2.Text = "UTC";
            // 
            // Schedulelive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(334, 401);
            this.ControlBox = false;
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.CanBtn);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.SchBtn);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.VideoTitleTextBox);
            this.Controls.Add(this.VideoDescriptionTextBox);
            this.Controls.Add(this.VideotagsTextBox);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.VideotagsLbl);
            this.Controls.Add(this.VideoTitleLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Schedulelive";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule live";
            this.Load += new System.EventHandler(this.Createlivevideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SchBtn;
        private System.Windows.Forms.Button CanBtn;
        private System.Windows.Forms.TextBox VideoTitleTextBox;
        private System.Windows.Forms.TextBox VideotagsTextBox;
        private System.Windows.Forms.Label VideotagsLbl;
        private System.Windows.Forms.Label VideoTitleLbl;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.TextBox VideoDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
    }
}