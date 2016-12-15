namespace Facebook_Live_Studio.Forms
{
    partial class Videocomments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
          base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
        private void InitializeComponent()
        {
            this.CommentsDataGridView = new System.Windows.Forms.DataGridView();
            this.CommentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectButton = new System.Windows.Forms.Button();
            this.QueDataGridView = new System.Windows.Forms.DataGridView();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PlayDataGridView = new System.Windows.Forms.DataGridView();
            this.VideoTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CommentsDataGridView
            // 
            this.CommentsDataGridView.AllowUserToAddRows = false;
            this.CommentsDataGridView.AllowUserToDeleteRows = false;
            this.CommentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CommentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentID,
            this.Namecolumn,
            this.Comment});
            this.CommentsDataGridView.Location = new System.Drawing.Point(12, 91);
            this.CommentsDataGridView.Name = "CommentsDataGridView";
            this.CommentsDataGridView.ReadOnly = true;
            this.CommentsDataGridView.RowHeadersVisible = false;
            this.CommentsDataGridView.Size = new System.Drawing.Size(900, 801);
            this.CommentsDataGridView.TabIndex = 2;
            this.CommentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommentsDataGridView_CellContentClick);
            // 
            // CommentID
            // 
            this.CommentID.HeaderText = "Comment ID";
            this.CommentID.Name = "CommentID";
            this.CommentID.ReadOnly = true;
            this.CommentID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CommentID.Visible = false;
            // 
            // Namecolumn
            // 
            this.Namecolumn.HeaderText = "Name";
            this.Namecolumn.Name = "Namecolumn";
            this.Namecolumn.ReadOnly = true;
            this.Namecolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Comment
            // 
            this.Comment.FillWeight = 500F;
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Comment.Width = 500;
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectButton.Location = new System.Drawing.Point(12, 916);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(120, 27);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Select Comment";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // QueDataGridView
            // 
            this.QueDataGridView.AllowUserToAddRows = false;
            this.QueDataGridView.AllowUserToDeleteRows = false;
            this.QueDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.QueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueDataGridView.Location = new System.Drawing.Point(992, 91);
            this.QueDataGridView.Name = "QueDataGridView";
            this.QueDataGridView.ReadOnly = true;
            this.QueDataGridView.Size = new System.Drawing.Size(900, 702);
            this.QueDataGridView.TabIndex = 4;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(138, 916);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(120, 27);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear and Refresh";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(992, 916);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(120, 27);
            this.PlayButton.TabIndex = 10;
            this.PlayButton.Text = "Play Comment";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // PlayDataGridView
            // 
            this.PlayDataGridView.AllowUserToAddRows = false;
            this.PlayDataGridView.AllowUserToDeleteRows = false;
            this.PlayDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayDataGridView.Location = new System.Drawing.Point(992, 839);
            this.PlayDataGridView.Name = "PlayDataGridView";
            this.PlayDataGridView.ReadOnly = true;
            this.PlayDataGridView.RowHeadersVisible = false;
            this.PlayDataGridView.Size = new System.Drawing.Size(900, 53);
            this.PlayDataGridView.TabIndex = 11;
            // 
            // VideoTitleLabel
            // 
            this.VideoTitleLabel.AutoSize = true;
            this.VideoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitleLabel.Location = new System.Drawing.Point(12, 27);
            this.VideoTitleLabel.Name = "VideoTitleLabel";
            this.VideoTitleLabel.Size = new System.Drawing.Size(142, 31);
            this.VideoTitleLabel.TabIndex = 0;
            this.VideoTitleLabel.Text = "Video Title";
            // 
            // Videocomments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 966);
            this.Controls.Add(this.VideoTitleLabel);
            this.Controls.Add(this.PlayDataGridView);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.QueDataGridView);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.CommentsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Videocomments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.Videocomments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CommentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CommentsDataGridView;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridView QueDataGridView;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.DataGridView PlayDataGridView;
        private System.Windows.Forms.Label VideoTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}