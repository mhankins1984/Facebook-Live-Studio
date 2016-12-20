namespace Facebook_Live_Studio.Forms
{
    partial class Pageselector
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
            this.PageDataGridView = new System.Windows.Forms.DataGridView();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PageDataGridView
            // 
            this.PageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageName,
            this.AccessToken});
            this.PageDataGridView.Location = new System.Drawing.Point(13, 13);
            this.PageDataGridView.Name = "PageDataGridView";
            this.PageDataGridView.Size = new System.Drawing.Size(259, 237);
            this.PageDataGridView.TabIndex = 0;
            // 
            // PageName
            // 
            this.PageName.HeaderText = "Name";
            this.PageName.Name = "PageName";
            // 
            // AccessToken
            // 
            this.AccessToken.HeaderText = "Access Token";
            this.AccessToken.Name = "AccessToken";
            // 
            // Pageselector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PageDataGridView);
            this.Name = "Pageselector";
            this.Text = "Pageselector";
            this.Load += new System.EventHandler(this.Pageselector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PageDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessToken;
    }
}