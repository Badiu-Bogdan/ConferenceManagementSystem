
namespace ConferenceManagementSystem.src.main.view
{
    partial class OrganizeSectionsStepTwo
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
            this.btn_abort = new System.Windows.Forms.Button();
            this.btn_organizeSections = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_sections = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listbx_selected = new System.Windows.Forms.ListBox();
            this.lbl_noPapers = new System.Windows.Forms.Label();
            this.listbx_schedule = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_conference = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_selectedDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.dtp_selectedEnd = new System.Windows.Forms.DateTimePicker();
            this.dtp_selectedStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_noSchedule = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_abort
            // 
            this.btn_abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_abort.Location = new System.Drawing.Point(14, 533);
            this.btn_abort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(85, 41);
            this.btn_abort.TabIndex = 10;
            this.btn_abort.Text = "Abort";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // btn_organizeSections
            // 
            this.btn_organizeSections.Enabled = false;
            this.btn_organizeSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_organizeSections.Location = new System.Drawing.Point(948, 533);
            this.btn_organizeSections.Margin = new System.Windows.Forms.Padding(4);
            this.btn_organizeSections.Name = "btn_organizeSections";
            this.btn_organizeSections.Size = new System.Drawing.Size(180, 41);
            this.btn_organizeSections.TabIndex = 17;
            this.btn_organizeSections.Text = "Organize Sections";
            this.btn_organizeSections.UseVisualStyleBackColor = true;
            this.btn_organizeSections.Click += new System.EventHandler(this.btn_organizeSections_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(107, 554);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Step 2/3: Set the schedule for each presentation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbx_sections
            // 
            this.cmbx_sections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_sections.FormattingEnabled = true;
            this.cmbx_sections.Location = new System.Drawing.Point(92, 12);
            this.cmbx_sections.Name = "cmbx_sections";
            this.cmbx_sections.Size = new System.Drawing.Size(283, 24);
            this.cmbx_sections.TabIndex = 21;
            this.cmbx_sections.SelectedIndexChanged += new System.EventHandler(this.cmbx_sections_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Sections";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listbx_selected
            // 
            this.listbx_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listbx_selected.FormattingEnabled = true;
            this.listbx_selected.ItemHeight = 20;
            this.listbx_selected.Location = new System.Drawing.Point(14, 42);
            this.listbx_selected.Name = "listbx_selected";
            this.listbx_selected.Size = new System.Drawing.Size(361, 424);
            this.listbx_selected.TabIndex = 22;
            this.listbx_selected.SelectedIndexChanged += new System.EventHandler(this.listbx_selected_SelectedIndexChanged);
            // 
            // lbl_noPapers
            // 
            this.lbl_noPapers.AutoSize = true;
            this.lbl_noPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_noPapers.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_noPapers.Location = new System.Drawing.Point(10, 478);
            this.lbl_noPapers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_noPapers.Name = "lbl_noPapers";
            this.lbl_noPapers.Size = new System.Drawing.Size(229, 20);
            this.lbl_noPapers.TabIndex = 23;
            this.lbl_noPapers.Text = "*No papers left in this section";
            this.lbl_noPapers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_noPapers.Visible = false;
            // 
            // listbx_schedule
            // 
            this.listbx_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listbx_schedule.FormattingEnabled = true;
            this.listbx_schedule.ItemHeight = 20;
            this.listbx_schedule.Location = new System.Drawing.Point(676, 39);
            this.listbx_schedule.Name = "listbx_schedule";
            this.listbx_schedule.Size = new System.Drawing.Size(452, 424);
            this.listbx_schedule.Sorted = true;
            this.listbx_schedule.TabIndex = 24;
            this.listbx_schedule.SelectedIndexChanged += new System.EventHandler(this.listbx_schedule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(672, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Schedule";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtp_conference
            // 
            this.dtp_conference.CustomFormat = "yyyy-MM-dd";
            this.dtp_conference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_conference.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_conference.Location = new System.Drawing.Point(972, 12);
            this.dtp_conference.Name = "dtp_conference";
            this.dtp_conference.Size = new System.Drawing.Size(155, 26);
            this.dtp_conference.TabIndex = 26;
            this.dtp_conference.Value = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            this.dtp_conference.ValueChanged += new System.EventHandler(this.dtp_conference_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(912, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtp_selectedDate
            // 
            this.dtp_selectedDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_selectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_selectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_selectedDate.Location = new System.Drawing.Point(120, 48);
            this.dtp_selectedDate.Name = "dtp_selectedDate";
            this.dtp_selectedDate.Size = new System.Drawing.Size(155, 26);
            this.dtp_selectedDate.TabIndex = 28;
            this.dtp_selectedDate.Value = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(14, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(14, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Schedule";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.btn_schedule);
            this.panel1.Controls.Add(this.dtp_selectedEnd);
            this.panel1.Controls.Add(this.dtp_selectedStart);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtp_selectedDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(381, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 225);
            this.panel1.TabIndex = 30;
            // 
            // btn_remove
            // 
            this.btn_remove.Enabled = false;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_remove.Location = new System.Drawing.Point(149, 168);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(126, 41);
            this.btn_remove.TabIndex = 33;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_schedule
            // 
            this.btn_schedule.Enabled = false;
            this.btn_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_schedule.Location = new System.Drawing.Point(15, 168);
            this.btn_schedule.Margin = new System.Windows.Forms.Padding(4);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(126, 41);
            this.btn_schedule.TabIndex = 32;
            this.btn_schedule.Text = "Schedule";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // dtp_selectedEnd
            // 
            this.dtp_selectedEnd.CustomFormat = "HH:mm";
            this.dtp_selectedEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_selectedEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_selectedEnd.Location = new System.Drawing.Point(120, 119);
            this.dtp_selectedEnd.Name = "dtp_selectedEnd";
            this.dtp_selectedEnd.Size = new System.Drawing.Size(155, 26);
            this.dtp_selectedEnd.TabIndex = 31;
            this.dtp_selectedEnd.Value = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            // 
            // dtp_selectedStart
            // 
            this.dtp_selectedStart.CustomFormat = "HH:mm";
            this.dtp_selectedStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_selectedStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_selectedStart.Location = new System.Drawing.Point(120, 87);
            this.dtp_selectedStart.Name = "dtp_selectedStart";
            this.dtp_selectedStart.Size = new System.Drawing.Size(155, 26);
            this.dtp_selectedStart.TabIndex = 31;
            this.dtp_selectedStart.Value = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(14, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "End time:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(14, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Start time:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_noSchedule
            // 
            this.lbl_noSchedule.AutoSize = true;
            this.lbl_noSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_noSchedule.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_noSchedule.Location = new System.Drawing.Point(672, 477);
            this.lbl_noSchedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_noSchedule.Name = "lbl_noSchedule";
            this.lbl_noSchedule.Size = new System.Drawing.Size(264, 20);
            this.lbl_noSchedule.TabIndex = 31;
            this.lbl_noSchedule.Text = "*No schedules for this day/section";
            this.lbl_noSchedule.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrganizeSectionsStepTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 590);
            this.Controls.Add(this.lbl_noSchedule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_conference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbx_schedule);
            this.Controls.Add(this.lbl_noPapers);
            this.Controls.Add(this.listbx_selected);
            this.Controls.Add(this.cmbx_sections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_organizeSections);
            this.Controls.Add(this.btn_abort);
            this.Name = "OrganizeSectionsStepTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organize Sections 2/3 CMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Button btn_organizeSections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_sections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbx_selected;
        private System.Windows.Forms.Label lbl_noPapers;
        private System.Windows.Forms.ListBox listbx_schedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_conference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_selectedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_selectedStart;
        private System.Windows.Forms.DateTimePicker dtp_selectedEnd;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_noSchedule;
    }
}