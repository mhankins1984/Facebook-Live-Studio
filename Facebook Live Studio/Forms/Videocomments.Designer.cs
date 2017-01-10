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
            this.PlyonBtn = new System.Windows.Forms.Button();
            this.LiveDataGridView = new System.Windows.Forms.DataGridView();
            this.VideoTitleLbl = new System.Windows.Forms.Label();
            this.RemBtn = new System.Windows.Forms.Button();
            this.PlyoffBtn = new System.Windows.Forms.Button();
            this.PreviewDataGridView = new System.Windows.Forms.DataGridView();
            this.PrvLbl = new System.Windows.Forms.Label();
            this.LiveLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.APCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommentsDataGridView
            // 
            this.CommentsDataGridView.AllowUserToAddRows = false;
            this.CommentsDataGridView.AllowUserToDeleteRows = false;
            this.CommentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentID,
            this.Namecolumn,
            this.Comment});
            this.CommentsDataGridView.Location = new System.Drawing.Point(12, 47);
            this.CommentsDataGridView.Name = "CommentsDataGridView";
            this.CommentsDataGridView.ReadOnly = true;
            this.CommentsDataGridView.RowHeadersVisible = false;
            this.CommentsDataGridView.Size = new System.Drawing.Size(800, 800);
            this.CommentsDataGridView.TabIndex = 2;
            this.CommentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommentsDataGridView_CellContentClick);
            this.CommentsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommentsDataGridView_CellContentDoubleClick);
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
            this.SelBtn.Location = new System.Drawing.Point(12, 853);
            this.SelBtn.Name = "SelBtn";
            this.SelBtn.Size = new System.Drawing.Size(75, 23);
            this.SelBtn.TabIndex = 3;
            this.SelBtn.Text = "&Select";
            this.SelBtn.UseVisualStyleBackColor = true;
            this.SelBtn.Click += new System.EventHandler(this.SelBtn_Click);
            // 
            // QueDataGridView
            // 
            this.QueDataGridView.AllowUserToAddRows = false;
            this.QueDataGridView.AllowUserToDeleteRows = false;
            this.QueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueDataGridView.Location = new System.Drawing.Point(836, 47);
            this.QueDataGridView.Name = "QueDataGridView";
            this.QueDataGridView.ReadOnly = true;
            this.QueDataGridView.Size = new System.Drawing.Size(800, 547);
            this.QueDataGridView.TabIndex = 4;
            this.QueDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QueDataGridView_CellContentDoubleClick);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Location = new System.Drawing.Point(93, 853);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(75, 23);
            this.ClrBtn.TabIndex = 5;
            this.ClrBtn.Text = "&Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // PlyonBtn
            // 
            this.PlyonBtn.Location = new System.Drawing.Point(835, 783);
            this.PlyonBtn.Name = "PlyonBtn";
            this.PlyonBtn.Size = new System.Drawing.Size(75, 23);
            this.PlyonBtn.TabIndex = 10;
            this.PlyonBtn.Text = "&Play On";
            this.PlyonBtn.UseVisualStyleBackColor = true;
            this.PlyonBtn.Click += new System.EventHandler(this.PlyBtn_Click);
            // 
            // LiveDataGridView
            // 
            this.LiveDataGridView.AllowUserToAddRows = false;
            this.LiveDataGridView.AllowUserToDeleteRows = false;
            this.LiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiveDataGridView.Location = new System.Drawing.Point(1251, 712);
            this.LiveDataGridView.Name = "LiveDataGridView";
            this.LiveDataGridView.ReadOnly = true;
            this.LiveDataGridView.RowHeadersVisible = false;
            this.LiveDataGridView.Size = new System.Drawing.Size(385, 65);
            this.LiveDataGridView.TabIndex = 11;
            // 
            // VideoTitleLbl
            // 
            this.VideoTitleLbl.AutoSize = true;
            this.VideoTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitleLbl.Location = new System.Drawing.Point(12, 9);
            this.VideoTitleLbl.Name = "VideoTitleLbl";
            this.VideoTitleLbl.Size = new System.Drawing.Size(142, 31);
            this.VideoTitleLbl.TabIndex = 0;
            this.VideoTitleLbl.Text = "Video Title";
            // 
            // RemBtn
            // 
            this.RemBtn.Location = new System.Drawing.Point(836, 600);
            this.RemBtn.Name = "RemBtn";
            this.RemBtn.Size = new System.Drawing.Size(75, 23);
            this.RemBtn.TabIndex = 12;
            this.RemBtn.Text = "&Remove";
            this.RemBtn.UseVisualStyleBackColor = true;
            this.RemBtn.Click += new System.EventHandler(this.RemBtn_Click);
            // 
            // PlyoffBtn
            // 
            this.PlyoffBtn.Location = new System.Drawing.Point(1251, 783);
            this.PlyoffBtn.Name = "PlyoffBtn";
            this.PlyoffBtn.Size = new System.Drawing.Size(75, 23);
            this.PlyoffBtn.TabIndex = 13;
            this.PlyoffBtn.Text = "Play &Off";
            this.PlyoffBtn.UseVisualStyleBackColor = true;
            this.PlyoffBtn.Click += new System.EventHandler(this.PlyoffBtn_Click);
            // 
            // PreviewDataGridView
            // 
            this.PreviewDataGridView.AllowUserToAddRows = false;
            this.PreviewDataGridView.AllowUserToDeleteRows = false;
            this.PreviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviewDataGridView.Location = new System.Drawing.Point(836, 712);
            this.PreviewDataGridView.Name = "PreviewDataGridView";
            this.PreviewDataGridView.ReadOnly = true;
            this.PreviewDataGridView.RowHeadersVisible = false;
            this.PreviewDataGridView.Size = new System.Drawing.Size(385, 65);
            this.PreviewDataGridView.TabIndex = 14;
            // 
            // PrvLbl
            // 
            this.PrvLbl.AutoSize = true;
            this.PrvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrvLbl.Location = new System.Drawing.Point(831, 684);
            this.PrvLbl.Name = "PrvLbl";
            this.PrvLbl.Size = new System.Drawing.Size(88, 25);
            this.PrvLbl.TabIndex = 15;
            this.PrvLbl.Text = "Preview";
            // 
            // LiveLbl
            // 
            this.LiveLbl.AutoSize = true;
            this.LiveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveLbl.Location = new System.Drawing.Point(1246, 684);
            this.LiveLbl.Name = "LiveLbl";
            this.LiveLbl.Size = new System.Drawing.Size(52, 25);
            this.LiveLbl.TabIndex = 16;
            this.LiveLbl.Text = "Live";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.APCheck);
            this.groupBox1.Location = new System.Drawing.Point(1251, 600);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 65);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // APCheck
            // 
            this.APCheck.AutoSize = true;
            this.APCheck.Checked = true;
            this.APCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.APCheck.Location = new System.Drawing.Point(6, 19);
            this.APCheck.Name = "APCheck";
            this.APCheck.Size = new System.Drawing.Size(89, 17);
            this.APCheck.TabIndex = 0;
            this.APCheck.Text = "Auto Preview";
            this.APCheck.UseVisualStyleBackColor = true;
            // 
            // Videocomments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1649, 886);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LiveLbl);
            this.Controls.Add(this.PrvLbl);
            this.Controls.Add(this.PreviewDataGridView);
            this.Controls.Add(this.PlyoffBtn);
            this.Controls.Add(this.RemBtn);
            this.Controls.Add(this.VideoTitleLbl);
            this.Controls.Add(this.LiveDataGridView);
            this.Controls.Add(this.PlyonBtn);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.QueDataGridView);
            this.Controls.Add(this.SelBtn);
            this.Controls.Add(this.CommentsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Videocomments";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Videocomments_Closing);
            this.Load += new System.EventHandler(this.Videocomments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CommentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CommentsDataGridView;
        private System.Windows.Forms.Button SelBtn;
        private System.Windows.Forms.DataGridView QueDataGridView;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Button PlyonBtn;
        private System.Windows.Forms.DataGridView LiveDataGridView;
        private System.Windows.Forms.Label VideoTitleLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button RemBtn;
        private System.Windows.Forms.Button PlyoffBtn;
        private System.Windows.Forms.DataGridView PreviewDataGridView;
        private System.Windows.Forms.Label PrvLbl;
        private System.Windows.Forms.Label LiveLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox APCheck;
    }
}