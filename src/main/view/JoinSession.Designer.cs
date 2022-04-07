
namespace ConferenceManagementSystem.src.main.view
{
    partial class JoinSession
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
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_selectedSessions = new System.Windows.Forms.ComboBox();
            this.btn_join = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listbx_schedule = new System.Windows.Forms.ListBox();
            this.lbl_usersJoined = new System.Windows.Forms.Label();
            this.dtp_conference = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nothingToShow = new System.Windows.Forms.Label();
            this.lbl_noMoreSpots = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(13, 435);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sessions:";
            // 
            // cmbx_selectedSessions
            // 
            this.cmbx_selectedSessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_selectedSessions.FormattingEnabled = true;
            this.cmbx_selectedSessions.Location = new System.Drawing.Point(97, 9);
            this.cmbx_selectedSessions.Name = "cmbx_selectedSessions";
            this.cmbx_selectedSessions.Size = new System.Drawing.Size(233, 24);
            this.cmbx_selectedSessions.TabIndex = 20;
            this.cmbx_selectedSessions.SelectedIndexChanged += new System.EventHandler(this.cmbx_selectedSessions_SelectedIndexChanged);
            // 
            // btn_join
            // 
            this.btn_join.Enabled = false;
            this.btn_join.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_join.Location = new System.Drawing.Point(376, 435);
            this.btn_join.Margin = new System.Windows.Forms.Padding(4);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(99, 41);
            this.btn_join.TabIndex = 21;
            this.btn_join.Text = "Join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Schedule:";
            // 
            // listbx_schedule
            // 
            this.listbx_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listbx_schedule.FormattingEnabled = true;
            this.listbx_schedule.ItemHeight = 20;
            this.listbx_schedule.Location = new System.Drawing.Point(11, 84);
            this.listbx_schedule.Name = "listbx_schedule";
            this.listbx_schedule.Size = new System.Drawing.Size(465, 344);
            this.listbx_schedule.Sorted = true;
            this.listbx_schedule.TabIndex = 25;
            // 
            // lbl_usersJoined
            // 
            this.lbl_usersJoined.AutoSize = true;
            this.lbl_usersJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_usersJoined.Location = new System.Drawing.Point(166, 431);
            this.lbl_usersJoined.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usersJoined.Name = "lbl_usersJoined";
            this.lbl_usersJoined.Size = new System.Drawing.Size(119, 20);
            this.lbl_usersJoined.TabIndex = 26;
            this.lbl_usersJoined.Text = "Users joined: -";
            this.lbl_usersJoined.Visible = false;
            // 
            // dtp_conference
            // 
            this.dtp_conference.CustomFormat = "yyyy-MM-dd";
            this.dtp_conference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_conference.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_conference.Location = new System.Drawing.Point(320, 54);
            this.dtp_conference.Name = "dtp_conference";
            this.dtp_conference.Size = new System.Drawing.Size(155, 26);
            this.dtp_conference.TabIndex = 29;
            this.dtp_conference.Value = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            this.dtp_conference.ValueChanged += new System.EventHandler(this.dtp_conference_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(263, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_nothingToShow
            // 
            this.lbl_nothingToShow.AutoSize = true;
            this.lbl_nothingToShow.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nothingToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_nothingToShow.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_nothingToShow.Location = new System.Drawing.Point(316, 94);
            this.lbl_nothingToShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nothingToShow.Name = "lbl_nothingToShow";
            this.lbl_nothingToShow.Size = new System.Drawing.Size(135, 20);
            this.lbl_nothingToShow.TabIndex = 33;
            this.lbl_nothingToShow.Text = "*Nothing to show";
            this.lbl_nothingToShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_nothingToShow.Visible = false;
            // 
            // lbl_noMoreSpots
            // 
            this.lbl_noMoreSpots.AutoSize = true;
            this.lbl_noMoreSpots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_noMoreSpots.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_noMoreSpots.Location = new System.Drawing.Point(166, 456);
            this.lbl_noMoreSpots.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_noMoreSpots.Name = "lbl_noMoreSpots";
            this.lbl_noMoreSpots.Size = new System.Drawing.Size(119, 20);
            this.lbl_noMoreSpots.TabIndex = 34;
            this.lbl_noMoreSpots.Text = "No more spots";
            this.lbl_noMoreSpots.Visible = false;
            // 
            // JoinSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 485);
            this.Controls.Add(this.lbl_noMoreSpots);
            this.Controls.Add(this.lbl_nothingToShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_conference);
            this.Controls.Add(this.lbl_usersJoined);
            this.Controls.Add(this.listbx_schedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.cmbx_selectedSessions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Name = "JoinSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Join Session CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_selectedSessions;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbx_schedule;
        private System.Windows.Forms.Label lbl_usersJoined;
        private System.Windows.Forms.DateTimePicker dtp_conference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nothingToShow;
        private System.Windows.Forms.Label lbl_noMoreSpots;
    }
}