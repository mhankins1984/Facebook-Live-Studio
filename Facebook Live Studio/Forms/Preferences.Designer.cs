namespace Live_Studio.Forms
{
    partial class Preferences
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
            this.SavBtn = new System.Windows.Forms.Button();
            this.CnlBtn = new System.Windows.Forms.Button();
            this.ComRefSec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComHoldSec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SavBtn
            // 
            this.SavBtn.Location = new System.Drawing.Point(247, 227);
            this.SavBtn.Name = "SavBtn";
            this.SavBtn.Size = new System.Drawing.Size(75, 23);
            this.SavBtn.TabIndex = 0;
            this.SavBtn.Text = "Save";
            this.SavBtn.UseVisualStyleBackColor = true;
            this.SavBtn.Click += new System.EventHandler(this.SavBtn_Click);
            // 
            // CnlBtn
            // 
            this.CnlBtn.Location = new System.Drawing.Point(166, 227);
            this.CnlBtn.Name = "CnlBtn";
            this.CnlBtn.Size = new System.Drawing.Size(75, 23);
            this.CnlBtn.TabIndex = 1;
            this.CnlBtn.Text = "Cancel";
            this.CnlBtn.UseVisualStyleBackColor = true;
            this.CnlBtn.Click += new System.EventHandler(this.CnlBtn_Click);
            // 
            // ComRefSec
            // 
            this.ComRefSec.Location = new System.Drawing.Point(64, 24);
            this.ComRefSec.Name = "ComRefSec";
            this.ComRefSec.Size = new System.Drawing.Size(100, 20);
            this.ComRefSec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seconds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seconds:";
            // 
            // ComHoldSec
            // 
            this.ComHoldSec.Location = new System.Drawing.Point(64, 22);
            this.ComHoldSec.Name = "ComHoldSec";
            this.ComHoldSec.Size = new System.Drawing.Size(100, 20);
            this.ComHoldSec.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComRefSec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Refresh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ComHoldSec);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 50);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comment Hold";
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CnlBtn);
            this.Controls.Add(this.SavBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Preferences";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SavBtn;
        private System.Windows.Forms.Button CnlBtn;
        private System.Windows.Forms.TextBox ComRefSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ComHoldSec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}