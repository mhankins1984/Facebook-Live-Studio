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
            this.SelBtn = new System.Windows.Forms.Button();
            this.QueDataGridView = new System.Windows.Forms.DataGridView();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.PlyBtn = new System.Windows.Forms.Button();
            this.PlayDataGridView = new System.Windows.Forms.DataGridView();
            this.VideoTitleLbl = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
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
            // SelBtn
            // 
            this.SelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelBtn.Location = new System.Drawing.Point(12, 898);
            this.SelBtn.Name = "SelBtn";
            this.SelBtn.Size = new System.Drawing.Size(75, 23);
            this.SelBtn.TabIndex = 3;
            this.SelBtn.Text = "Select";
            this.SelBtn.UseVisualStyleBackColor = true;
            this.SelBtn.Click += new System.EventHandler(this.SelBtn_Click);
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
            // ClrBtn
            // 
            this.ClrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClrBtn.Location = new System.Drawing.Point(93, 898);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(75, 23);
            this.ClrBtn.TabIndex = 5;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // PlyBtn
            // 
            this.PlyBtn.Location = new System.Drawing.Point(992, 898);
            this.PlyBtn.Name = "PlyBtn";
            this.PlyBtn.Size = new System.Drawing.Size(75, 23);
            this.PlyBtn.TabIndex = 10;
            this.PlyBtn.Text = "Play";
            this.PlyBtn.UseVisualStyleBackColor = true;
            this.PlyBtn.Click += new System.EventHandler(this.PlyBtn_Click);
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
            // VideoTitleLbl
            // 
            this.VideoTitleLbl.AutoSize = true;
            this.VideoTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitleLbl.Location = new System.Drawing.Point(12, 27);
            this.VideoTitleLbl.Name = "VideoTitleLbl";
            this.VideoTitleLbl.Size = new System.Drawing.Size(142, 31);
            this.VideoTitleLbl.TabIndex = 0;
            this.VideoTitleLbl.Text = "Video Title";
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(1232, 897);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 23);
            this.Btn1.TabIndex = 12;
            this.Btn1.Text = "Btn1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Videocomments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 966);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.VideoTitleLbl);
            this.Controls.Add(this.PlayDataGridView);
            this.Controls.Add(this.PlyBtn);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.QueDataGridView);
            this.Controls.Add(this.SelBtn);
            this.Controls.Add(this.CommentsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Videocomments";
            this.ShowInTaskbar = false;
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
        private System.Windows.Forms.Button SelBtn;
        private System.Windows.Forms.DataGridView QueDataGridView;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Button PlyBtn;
        private System.Windows.Forms.DataGridView PlayDataGridView;
        private System.Windows.Forms.Label VideoTitleLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Button Btn1;
    }
}