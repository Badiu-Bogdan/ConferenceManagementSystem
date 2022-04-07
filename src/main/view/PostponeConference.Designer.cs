
namespace ConferenceManagementSystem.src.main.view
{
    partial class PostponeConference
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
            this.dtp_ConferencePaper = new System.Windows.Forms.DateTimePicker();
            this.btn_postponePaper = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_cfpDeadlinePaper = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_cfpDeadlineProp = new System.Windows.Forms.DateTimePicker();
            this.dtp_ConferenceProp = new System.Windows.Forms.DateTimePicker();
            this.btn_postponeProp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_ConferencePaper
            // 
            this.dtp_ConferencePaper.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_ConferencePaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_ConferencePaper.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ConferencePaper.Location = new System.Drawing.Point(427, 80);
            this.dtp_ConferencePaper.Name = "dtp_ConferencePaper";
            this.dtp_ConferencePaper.Size = new System.Drawing.Size(259, 26);
            this.dtp_ConferencePaper.TabIndex = 1;
            this.dtp_ConferencePaper.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // btn_postponePaper
            // 
            this.btn_postponePaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_postponePaper.Location = new System.Drawing.Point(537, 121);
            this.btn_postponePaper.Name = "btn_postponePaper";
            this.btn_postponePaper.Size = new System.Drawing.Size(149, 41);
            this.btn_postponePaper.TabIndex = 7;
            this.btn_postponePaper.Text = "Postpone";
            this.btn_postponePaper.UseVisualStyleBackColor = true;
            this.btn_postponePaper.Click += new System.EventHandler(this.btn_postpone_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(9, 350);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 41);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current Call For Papers Deadline:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "New Deadline:";
            // 
            // dtp_cfpDeadlinePaper
            // 
            this.dtp_cfpDeadlinePaper.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_cfpDeadlinePaper.Enabled = false;
            this.dtp_cfpDeadlinePaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_cfpDeadlinePaper.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_cfpDeadlinePaper.Location = new System.Drawing.Point(427, 40);
            this.dtp_cfpDeadlinePaper.Name = "dtp_cfpDeadlinePaper";
            this.dtp_cfpDeadlinePaper.Size = new System.Drawing.Size(259, 26);
            this.dtp_cfpDeadlinePaper.TabIndex = 16;
            this.dtp_cfpDeadlinePaper.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(56, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current Call For Papers Deadline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "New Deadline:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_postponeProp);
            this.groupBox1.Controls.Add(this.dtp_cfpDeadlineProp);
            this.groupBox1.Controls.Add(this.dtp_ConferenceProp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 154);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "For Proposals";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_cfpDeadlinePaper);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_postponePaper);
            this.groupBox2.Controls.Add(this.dtp_ConferencePaper);
            this.groupBox2.Location = new System.Drawing.Point(9, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 171);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "For Papers";
            // 
            // dtp_cfpDeadlineProp
            // 
            this.dtp_cfpDeadlineProp.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_cfpDeadlineProp.Enabled = false;
            this.dtp_cfpDeadlineProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_cfpDeadlineProp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_cfpDeadlineProp.Location = new System.Drawing.Point(427, 30);
            this.dtp_cfpDeadlineProp.Name = "dtp_cfpDeadlineProp";
            this.dtp_cfpDeadlineProp.Size = new System.Drawing.Size(259, 26);
            this.dtp_cfpDeadlineProp.TabIndex = 18;
            this.dtp_cfpDeadlineProp.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // dtp_ConferenceProp
            // 
            this.dtp_ConferenceProp.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_ConferenceProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_ConferenceProp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ConferenceProp.Location = new System.Drawing.Point(427, 70);
            this.dtp_ConferenceProp.Name = "dtp_ConferenceProp";
            this.dtp_ConferenceProp.Size = new System.Drawing.Size(259, 26);
            this.dtp_ConferenceProp.TabIndex = 17;
            this.dtp_ConferenceProp.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // btn_postponeProp
            // 
            this.btn_postponeProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_postponeProp.Location = new System.Drawing.Point(537, 107);
            this.btn_postponeProp.Name = "btn_postponeProp";
            this.btn_postponeProp.Size = new System.Drawing.Size(149, 41);
            this.btn_postponeProp.TabIndex = 19;
            this.btn_postponeProp.Text = "Postpone";
            this.btn_postponeProp.UseVisualStyleBackColor = true;
            this.btn_postponeProp.Click += new System.EventHandler(this.btn_postponeProp_Click);
            // 
            // PostponeConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_back);
            this.Name = "PostponeConference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postpone Conference CMS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_ConferencePaper;
        private System.Windows.Forms.Button btn_postponePaper;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_cfpDeadlinePaper;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_cfpDeadlineProp;
        private System.Windows.Forms.DateTimePicker dtp_ConferenceProp;
        private System.Windows.Forms.Button btn_postponeProp;
    }
}