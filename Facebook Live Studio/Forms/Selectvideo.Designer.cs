namespace Facebook_Live_Studio.Forms
{
    partial class Selectvideo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tilte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelBtn = new System.Windows.Forms.Button();
            this.CanBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Tilte,
            this.VideoId,
            this.StreamKey});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(310, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Tilte
            // 
            this.Tilte.HeaderText = "Title";
            this.Tilte.Name = "Tilte";
            this.Tilte.ReadOnly = true;
            // 
            // VideoId
            // 
            this.VideoId.HeaderText = "Video ID";
            this.VideoId.Name = "VideoId";
            this.VideoId.ReadOnly = true;
            this.VideoId.Visible = false;
            // 
            // StreamKey
            // 
            this.StreamKey.HeaderText = "Stream Key";
            this.StreamKey.Name = "StreamKey";
            this.StreamKey.ReadOnly = true;
            this.StreamKey.Visible = false;
            // 
            // SelBtn
            // 
            this.SelBtn.Location = new System.Drawing.Point(247, 388);
            this.SelBtn.Name = "SelBtn";
            this.SelBtn.Size = new System.Drawing.Size(75, 23);
            this.SelBtn.TabIndex = 1;
            this.SelBtn.Text = "Select";
            this.SelBtn.UseVisualStyleBackColor = true;
            this.SelBtn.Click += new System.EventHandler(this.SelBtn_Click);
            // 
            // CanBtn
            // 
            this.CanBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanBtn.Location = new System.Drawing.Point(12, 388);
            this.CanBtn.Name = "CanBtn";
            this.CanBtn.Size = new System.Drawing.Size(75, 23);
            this.CanBtn.TabIndex = 3;
            this.CanBtn.Text = "Cancel";
            this.CanBtn.UseVisualStyleBackColor = true;
            this.CanBtn.Click += new System.EventHandler(this.CanBtn_Click);
            // 
            // Selectvideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 422);
            this.ControlBox = false;
            this.Controls.Add(this.CanBtn);
            this.Controls.Add(this.SelBtn);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selectvideo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Video";
            this.Load += new System.EventHandler(this.Selectvideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SelBtn;
        private System.Windows.Forms.Button CanBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tilte;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamKey;
    }
}