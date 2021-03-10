
namespace SlowDown
{
    partial class Form1
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
            this.cpuBurners = new System.Windows.Forms.CheckBox();
            this.randomBluescreen = new System.Windows.Forms.CheckBox();
            this.lag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGithub = new System.Windows.Forms.LinkLabel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpuBurners
            // 
            this.cpuBurners.AutoSize = true;
            this.cpuBurners.Location = new System.Drawing.Point(12, 83);
            this.cpuBurners.Name = "cpuBurners";
            this.cpuBurners.Size = new System.Drawing.Size(93, 17);
            this.cpuBurners.TabIndex = 0;
            this.cpuBurners.Text = "CPU Burner(s)";
            this.cpuBurners.UseVisualStyleBackColor = true;
            // 
            // randomBluescreen
            // 
            this.randomBluescreen.AutoSize = true;
            this.randomBluescreen.Location = new System.Drawing.Point(12, 115);
            this.randomBluescreen.Name = "randomBluescreen";
            this.randomBluescreen.Size = new System.Drawing.Size(121, 17);
            this.randomBluescreen.TabIndex = 1;
            this.randomBluescreen.Text = "Random bluescreen";
            this.randomBluescreen.UseVisualStyleBackColor = true;
            // 
            // lag
            // 
            this.lag.AutoSize = true;
            this.lag.Location = new System.Drawing.Point(12, 150);
            this.lag.Name = "lag";
            this.lag.Size = new System.Drawing.Size(44, 17);
            this.lag.TabIndex = 2;
            this.lag.Text = "Lag";
            this.lag.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "SlowDown v{version}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "made by virtualtoja: ";
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.Location = new System.Drawing.Point(15, 57);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(145, 13);
            this.lblGithub.TabIndex = 5;
            this.lblGithub.TabStop = true;
            this.lblGithub.Text = "https://github.com/virtualtoja";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(188, 92);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(188, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 178);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lag);
            this.Controls.Add(this.randomBluescreen);
            this.Controls.Add(this.cpuBurners);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "SlowDown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cpuBurners;
        private System.Windows.Forms.CheckBox randomBluescreen;
        private System.Windows.Forms.CheckBox lag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblGithub;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStart;
    }
}

