
namespace SlowDown
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDone);
            this.groupBox1.Controls.Add(this.lblInfo2);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.lblInfo1);
            this.groupBox1.Controls.Add(this.txtPercentage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Burner settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPercentage
            // 
            this.txtPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercentage.Location = new System.Drawing.Point(83, 20);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(226, 20);
            this.txtPercentage.TabIndex = 0;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(12, 23);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(65, 13);
            this.lblInfo1.TabIndex = 1;
            this.lblInfo1.Text = "Percentage:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(12, 49);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(33, 13);
            this.lblInfo2.TabIndex = 3;
            this.lblInfo2.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.Location = new System.Drawing.Point(83, 46);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(226, 20);
            this.txtTime.TabIndex = 2;
            // 
            // btnDone
            // 
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDone.Location = new System.Drawing.Point(3, 197);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(309, 23);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 223);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.TextBox txtPercentage;
    }
}