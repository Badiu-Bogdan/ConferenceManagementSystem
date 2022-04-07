
namespace ConferenceManagementSystem.src.main.view
{
    partial class ViewSchedule
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
            this.listbx_schedule = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_conference = new System.Windows.Forms.DateTimePicker();
            this.cmbx_sections = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nothingToShow = new System.Windows.Forms.Label();
            this.lbl_assignedSessionChair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_room = new System.Windows.Forms.Label();
            this.lbl_usersJoined = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(13, 557);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // listbx_schedule
            // 
            this.listbx_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listbx_schedule.FormattingEnabled = true;
            this.listbx_schedule.ItemHeight = 20;
            this.listbx_schedule.Location = new System.Drawing.Point(12, 41);
            this.listbx_schedule.Name = "listbx_schedule";
            this.listbx_schedule.Size = new System.Drawing.Size(583, 424);
            this.listbx_schedule.Sorted = true;
            this.listbx_schedule.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtp_conference
            // 
            this.dtp_conference.CustomFormat = "yyyy-MM-dd";
            this.dtp_conference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_conference.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_conference.Location = new System.Drawing.Point(70, 9);
            this.dtp_conference.Name = "dtp_conference";
            this.dtp_conference.Size = new System.Drawing.Size(155, 26);
            this.dtp_conference.TabIndex = 28;
            this.dtp_conference.Value = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            this.dtp_conference.ValueChanged += new System.EventHandler(this.dtp_conference_ValueChanged);
            // 
            // cmbx_sections
            // 
            this.cmbx_sections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_sections.FormattingEnabled = true;
            this.cmbx_sections.Location = new System.Drawing.Point(314, 9);
            this.cmbx_sections.Name = "cmbx_sections";
            this.cmbx_sections.Size = new System.Drawing.Size(281, 24);
            this.cmbx_sections.TabIndex = 31;
            this.cmbx_sections.SelectedIndexChanged += new System.EventHandler(this.cmbx_sections_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Section";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_nothingToShow
            // 
            this.lbl_nothingToShow.AutoSize = true;
            this.lbl_nothingToShow.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nothingToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_nothingToShow.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_nothingToShow.Location = new System.Drawing.Point(430, 51);
            this.lbl_nothingToShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nothingToShow.Name = "lbl_nothingToShow";
            this.lbl_nothingToShow.Size = new System.Drawing.Size(135, 20);
            this.lbl_nothingToShow.TabIndex = 32;
            this.lbl_nothingToShow.Text = "*Nothing to show";
            this.lbl_nothingToShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_nothingToShow.Visible = false;
            // 
            // lbl_assignedSessionChair
            // 
            this.lbl_assignedSessionChair.AutoSize = true;
            this.lbl_assignedSessionChair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_assignedSessionChair.Location = new System.Drawing.Point(13, 490);
            this.lbl_assignedSessionChair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_assignedSessionChair.Name = "lbl_assignedSessionChair";
            this.lbl_assignedSessionChair.Size = new System.Drawing.Size(15, 20);
            this.lbl_assignedSessionChair.TabIndex = 33;
            this.lbl_assignedSessionChair.Text = "-";
            this.lbl_assignedSessionChair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 468);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Assigned Session Chair:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_room.Location = new System.Drawing.Point(13, 519);
            this.lbl_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(69, 20);
            this.lbl_room.TabIndex = 35;
            this.lbl_room.Text = "Room: -";
            this.lbl_room.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_usersJoined
            // 
            this.lbl_usersJoined.AutoSize = true;
            this.lbl_usersJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_usersJoined.Location = new System.Drawing.Point(137, 557);
            this.lbl_usersJoined.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usersJoined.Name = "lbl_usersJoined";
            this.lbl_usersJoined.Size = new System.Drawing.Size(119, 20);
            this.lbl_usersJoined.TabIndex = 36;
            this.lbl_usersJoined.Text = "UsersJoined: -";
            this.lbl_usersJoined.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 611);
            this.Controls.Add(this.lbl_usersJoined);
            this.Controls.Add(this.lbl_room);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_assignedSessionChair);
            this.Controls.Add(this.lbl_nothingToShow);
            this.Controls.Add(this.cmbx_sections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_conference);
            this.Controls.Add(this.listbx_schedule);
            this.Controls.Add(this.btn_back);
            this.Name = "ViewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Schedule CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox listbx_schedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_conference;
        private System.Windows.Forms.ComboBox cmbx_sections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nothingToShow;
        private System.Windows.Forms.Label lbl_assignedSessionChair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.Label lbl_usersJoined;
    }
}