namespace Facebook_Live_Studio.Forms
{
    partial class Selectpage
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PageDataGridView
            // 
            this.PageDataGridView.AllowUserToAddRows = false;
            this.PageDataGridView.AllowUserToDeleteRows = false;
            this.PageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageName,
            this.AccessToken,
            this.ID});
            this.PageDataGridView.Location = new System.Drawing.Point(13, 13);
            this.PageDataGridView.Name = "PageDataGridView";
            this.PageDataGridView.ReadOnly = true;
            this.PageDataGridView.RowHeadersVisible = false;
            this.PageDataGridView.Size = new System.Drawing.Size(435, 237);
            this.PageDataGridView.TabIndex = 0;
            // 
            // PageName
            // 
            this.PageName.HeaderText = "Page";
            this.PageName.Name = "PageName";
            this.PageName.ReadOnly = true;
            // 
            // AccessToken
            // 
            this.AccessToken.HeaderText = "Access Token";
            this.AccessToken.Name = "AccessToken";
            this.AccessToken.ReadOnly = true;
            this.AccessToken.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "Page ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(12, 256);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(373, 256);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Selectpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(462, 286);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.PageDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selectpage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select page to manage";
            this.Load += new System.EventHandler(this.Pageselector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PageDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PageDataGridView;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button CancelButton;
    }
}