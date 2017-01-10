namespace Facebook_Live_Studio.Forms
{
    partial class SystemConfiguration
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
            this.ChyronTB = new System.Windows.Forms.TextBox();
            this.ObsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavBtn = new System.Windows.Forms.Button();
            this.CnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChyronTB
            // 
            this.ChyronTB.Location = new System.Drawing.Point(12, 29);
            this.ChyronTB.Name = "ChyronTB";
            this.ChyronTB.Size = new System.Drawing.Size(100, 20);
            this.ChyronTB.TabIndex = 0;
            // 
            // ObsTB
            // 
            this.ObsTB.Location = new System.Drawing.Point(12, 68);
            this.ObsTB.Name = "ObsTB";
            this.ObsTB.Size = new System.Drawing.Size(310, 20);
            this.ObsTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OBS JSON Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chyron Address";
            // 
            // SavBtn
            // 
            this.SavBtn.Location = new System.Drawing.Point(247, 93);
            this.SavBtn.Name = "SavBtn";
            this.SavBtn.Size = new System.Drawing.Size(75, 23);
            this.SavBtn.TabIndex = 4;
            this.SavBtn.Text = "Save Settings";
            this.SavBtn.UseVisualStyleBackColor = true;
            this.SavBtn.Click += new System.EventHandler(this.SavBtn_Click);
            // 
            // CnlBtn
            // 
            this.CnlBtn.Location = new System.Drawing.Point(166, 93);
            this.CnlBtn.Name = "CnlBtn";
            this.CnlBtn.Size = new System.Drawing.Size(75, 23);
            this.CnlBtn.TabIndex = 5;
            this.CnlBtn.Text = "Cancel";
            this.CnlBtn.UseVisualStyleBackColor = true;
            this.CnlBtn.Click += new System.EventHandler(this.CnlBtn_Click);
            // 
            // SystemConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 128);
            this.Controls.Add(this.CnlBtn);
            this.Controls.Add(this.SavBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObsTB);
            this.Controls.Add(this.ChyronTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SystemConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Configuration";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChyronTB;
        private System.Windows.Forms.TextBox ObsTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SavBtn;
        private System.Windows.Forms.Button CnlBtn;
    }
}