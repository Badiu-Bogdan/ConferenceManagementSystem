
namespace ConferenceManagementSystem.src.main.view
{
    partial class ConferenceForm
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
            this.btn_postponeConfDead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_ConferenceDetails = new System.Windows.Forms.Panel();
            this.lbl_requirePaper = new System.Windows.Forms.Label();
            this.lbl_confInProgress = new System.Windows.Forms.Label();
            this.dtp_confEndCFPPaper = new System.Windows.Forms.DateTimePicker();
            this.dtp_confEndCFPProp = new System.Windows.Forms.DateTimePicker();
            this.dtp_confStartCFP = new System.Windows.Forms.DateTimePicker();
            this.dtp_confEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_confStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtb_organizer = new System.Windows.Forms.TextBox();
            this.txtb_confDesc = new System.Windows.Forms.TextBox();
            this.txtb_confTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_uploadFullPaper = new System.Windows.Forms.Button();
            this.btn_paperDetails = new System.Windows.Forms.Button();
            this.btn_uploadNewPaperVersion = new System.Windows.Forms.Button();
            this.btn_uploadNewVersionAbstractPaper = new System.Windows.Forms.Button();
            this.btn_uploadAbstractPaper = new System.Windows.Forms.Button();
            this.btn_bidProposal = new System.Windows.Forms.Button();
            this.lbl_cfpOver = new System.Windows.Forms.Label();
            this.btn_Review_Paper = new System.Windows.Forms.Button();
            this.btn_decide_verdict = new System.Windows.Forms.Button();
            this.btn_chat = new System.Windows.Forms.Button();
            this.btn_organizeSections = new System.Windows.Forms.Button();
            this.btn_viewSchedule = new System.Windows.Forms.Button();
            this.btn_assignChairsToSections = new System.Windows.Forms.Button();
            this.btn_joinSession = new System.Windows.Forms.Button();
            this.btn_Send_Email = new System.Windows.Forms.Button();
            this.btn_upload_presentation = new System.Windows.Forms.Button();
            this.lbl_periodReview1 = new System.Windows.Forms.Label();
            this.lbl_periodBid = new System.Windows.Forms.Label();
            this.lbl_periodOrganization = new System.Windows.Forms.Label();
            this.pnl_periods = new System.Windows.Forms.Panel();
            this.lbl_periodBeforeConference = new System.Windows.Forms.Label();
            this.lbl_periodReview2 = new System.Windows.Forms.Label();
            this.panel_ConferenceDetails.SuspendLayout();
            this.pnl_periods.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(7, 632);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(137, 48);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_organizeConference_Click);
            // 
            // btn_postponeConfDead
            // 
            this.btn_postponeConfDead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_postponeConfDead.Location = new System.Drawing.Point(222, 453);
            this.btn_postponeConfDead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_postponeConfDead.Name = "btn_postponeConfDead";
            this.btn_postponeConfDead.Size = new System.Drawing.Size(253, 48);
            this.btn_postponeConfDead.TabIndex = 9;
            this.btn_postponeConfDead.Text = "Postpone Conference Deadline";
            this.btn_postponeConfDead.UseVisualStyleBackColor = true;
            this.btn_postponeConfDead.Click += new System.EventHandler(this.btn_postponeConfDead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Conference Details:";
            // 
            // panel_ConferenceDetails
            // 
            this.panel_ConferenceDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ConferenceDetails.Controls.Add(this.lbl_requirePaper);
            this.panel_ConferenceDetails.Controls.Add(this.lbl_confInProgress);
            this.panel_ConferenceDetails.Controls.Add(this.dtp_confEndCFPPaper);
            this.panel_ConferenceDetails.Controls.Add(this.dtp_confEndCFPProp);
            this.panel_ConferenceDetails.Controls.Add(this.dtp_confStartCFP);
            this.panel_ConferenceDetails.Controls.Add(this.dtp_confEndDate);
            this.panel_ConferenceDetails.Controls.Add(this.dtp_confStartDate);
            this.panel_ConferenceDetails.Controls.Add(this.txtb_organizer);
            this.panel_ConferenceDetails.Controls.Add(this.txtb_confDesc);
            this.panel_ConferenceDetails.Controls.Add(this.txtb_confTitle);
            this.panel_ConferenceDetails.Controls.Add(this.label8);
            this.panel_ConferenceDetails.Controls.Add(this.label9);
            this.panel_ConferenceDetails.Controls.Add(this.label7);
            this.panel_ConferenceDetails.Controls.Add(this.label6);
            this.panel_ConferenceDetails.Controls.Add(this.label5);
            this.panel_ConferenceDetails.Controls.Add(this.label4);
            this.panel_ConferenceDetails.Controls.Add(this.label3);
            this.panel_ConferenceDetails.Controls.Add(this.label2);
            this.panel_ConferenceDetails.Controls.Add(this.label1);
            this.panel_ConferenceDetails.Location = new System.Drawing.Point(13, 12);
            this.panel_ConferenceDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_ConferenceDetails.Name = "panel_ConferenceDetails";
            this.panel_ConferenceDetails.Size = new System.Drawing.Size(463, 428);
            this.panel_ConferenceDetails.TabIndex = 11;
            this.panel_ConferenceDetails.Tag = "";
            // 
            // lbl_requirePaper
            // 
            this.lbl_requirePaper.AutoSize = true;
            this.lbl_requirePaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_requirePaper.Location = new System.Drawing.Point(16, 400);
            this.lbl_requirePaper.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_requirePaper.Name = "lbl_requirePaper";
            this.lbl_requirePaper.Size = new System.Drawing.Size(123, 20);
            this.lbl_requirePaper.TabIndex = 23;
            this.lbl_requirePaper.Text = "Requires paper";
            // 
            // lbl_confInProgress
            // 
            this.lbl_confInProgress.AutoSize = true;
            this.lbl_confInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_confInProgress.ForeColor = System.Drawing.Color.Green;
            this.lbl_confInProgress.Location = new System.Drawing.Point(211, 9);
            this.lbl_confInProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_confInProgress.Name = "lbl_confInProgress";
            this.lbl_confInProgress.Size = new System.Drawing.Size(184, 20);
            this.lbl_confInProgress.TabIndex = 22;
            this.lbl_confInProgress.Text = "Conference in progress";
            this.lbl_confInProgress.Visible = false;
            // 
            // dtp_confEndCFPPaper
            // 
            this.dtp_confEndCFPPaper.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_confEndCFPPaper.Enabled = false;
            this.dtp_confEndCFPPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_confEndCFPPaper.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_confEndCFPPaper.Location = new System.Drawing.Point(133, 246);
            this.dtp_confEndCFPPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_confEndCFPPaper.Name = "dtp_confEndCFPPaper";
            this.dtp_confEndCFPPaper.Size = new System.Drawing.Size(315, 26);
            this.dtp_confEndCFPPaper.TabIndex = 18;
            this.dtp_confEndCFPPaper.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // dtp_confEndCFPProp
            // 
            this.dtp_confEndCFPProp.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_confEndCFPProp.Enabled = false;
            this.dtp_confEndCFPProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_confEndCFPProp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_confEndCFPProp.Location = new System.Drawing.Point(133, 193);
            this.dtp_confEndCFPProp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_confEndCFPProp.Name = "dtp_confEndCFPProp";
            this.dtp_confEndCFPProp.Size = new System.Drawing.Size(315, 26);
            this.dtp_confEndCFPProp.TabIndex = 18;
            this.dtp_confEndCFPProp.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // dtp_confStartCFP
            // 
            this.dtp_confStartCFP.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_confStartCFP.Enabled = false;
            this.dtp_confStartCFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_confStartCFP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_confStartCFP.Location = new System.Drawing.Point(133, 158);
            this.dtp_confStartCFP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_confStartCFP.Name = "dtp_confStartCFP";
            this.dtp_confStartCFP.Size = new System.Drawing.Size(315, 26);
            this.dtp_confStartCFP.TabIndex = 18;
            this.dtp_confStartCFP.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // dtp_confEndDate
            // 
            this.dtp_confEndDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_confEndDate.Enabled = false;
            this.dtp_confEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_confEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_confEndDate.Location = new System.Drawing.Point(133, 335);
            this.dtp_confEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_confEndDate.Name = "dtp_confEndDate";
            this.dtp_confEndDate.Size = new System.Drawing.Size(315, 26);
            this.dtp_confEndDate.TabIndex = 17;
            this.dtp_confEndDate.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // dtp_confStartDate
            // 
            this.dtp_confStartDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_confStartDate.Enabled = false;
            this.dtp_confStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_confStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_confStartDate.Location = new System.Drawing.Point(133, 303);
            this.dtp_confStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_confStartDate.Name = "dtp_confStartDate";
            this.dtp_confStartDate.Size = new System.Drawing.Size(315, 26);
            this.dtp_confStartDate.TabIndex = 17;
            this.dtp_confStartDate.Value = new System.DateTime(2021, 4, 17, 20, 52, 28, 0);
            // 
            // txtb_organizer
            // 
            this.txtb_organizer.Enabled = false;
            this.txtb_organizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_organizer.Location = new System.Drawing.Point(133, 368);
            this.txtb_organizer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb_organizer.Name = "txtb_organizer";
            this.txtb_organizer.Size = new System.Drawing.Size(315, 26);
            this.txtb_organizer.TabIndex = 12;
            // 
            // txtb_confDesc
            // 
            this.txtb_confDesc.Enabled = false;
            this.txtb_confDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_confDesc.Location = new System.Drawing.Point(133, 74);
            this.txtb_confDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb_confDesc.Multiline = true;
            this.txtb_confDesc.Name = "txtb_confDesc";
            this.txtb_confDesc.Size = new System.Drawing.Size(315, 77);
            this.txtb_confDesc.TabIndex = 12;
            // 
            // txtb_confTitle
            // 
            this.txtb_confTitle.Enabled = false;
            this.txtb_confTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_confTitle.Location = new System.Drawing.Point(133, 42);
            this.txtb_confTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb_confTitle.Name = "txtb_confTitle";
            this.txtb_confTitle.Size = new System.Drawing.Size(315, 26);
            this.txtb_confTitle.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Organizer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(12, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 40);
            this.label9.TabIndex = 11;
            this.label9.Text = "End of CFP\r\n(papers)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "End of CFP\r\n(proposals)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(11, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Start of CFP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "End date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title:";
            // 
            // btn_uploadFullPaper
            // 
            this.btn_uploadFullPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_uploadFullPaper.Location = new System.Drawing.Point(493, 125);
            this.btn_uploadFullPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_uploadFullPaper.Name = "btn_uploadFullPaper";
            this.btn_uploadFullPaper.Size = new System.Drawing.Size(211, 42);
            this.btn_uploadFullPaper.TabIndex = 12;
            this.btn_uploadFullPaper.Text = "Upload Full Paper";
            this.btn_uploadFullPaper.UseVisualStyleBackColor = true;
            this.btn_uploadFullPaper.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_paperDetails
            // 
            this.btn_paperDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_paperDetails.Location = new System.Drawing.Point(492, 243);
            this.btn_paperDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_paperDetails.Name = "btn_paperDetails";
            this.btn_paperDetails.Size = new System.Drawing.Size(211, 42);
            this.btn_paperDetails.TabIndex = 13;
            this.btn_paperDetails.Text = "Conference Entry";
            this.btn_paperDetails.UseVisualStyleBackColor = true;
            this.btn_paperDetails.Click += new System.EventHandler(this.btn_paperDetails_Click);
            // 
            // btn_uploadNewPaperVersion
            // 
            this.btn_uploadNewPaperVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_uploadNewPaperVersion.Location = new System.Drawing.Point(493, 172);
            this.btn_uploadNewPaperVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_uploadNewPaperVersion.Name = "btn_uploadNewPaperVersion";
            this.btn_uploadNewPaperVersion.Size = new System.Drawing.Size(211, 61);
            this.btn_uploadNewPaperVersion.TabIndex = 14;
            this.btn_uploadNewPaperVersion.Text = "Upload New Paper Version";
            this.btn_uploadNewPaperVersion.UseVisualStyleBackColor = true;
            this.btn_uploadNewPaperVersion.Click += new System.EventHandler(this.btn_uploadNewPaperVersion_Click);
            // 
            // btn_uploadNewVersionAbstractPaper
            // 
            this.btn_uploadNewVersionAbstractPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_uploadNewVersionAbstractPaper.Location = new System.Drawing.Point(493, 58);
            this.btn_uploadNewVersionAbstractPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_uploadNewVersionAbstractPaper.Name = "btn_uploadNewVersionAbstractPaper";
            this.btn_uploadNewVersionAbstractPaper.Size = new System.Drawing.Size(211, 63);
            this.btn_uploadNewVersionAbstractPaper.TabIndex = 16;
            this.btn_uploadNewVersionAbstractPaper.Text = "Upload New Abstract Paper Version";
            this.btn_uploadNewVersionAbstractPaper.UseVisualStyleBackColor = true;
            this.btn_uploadNewVersionAbstractPaper.Click += new System.EventHandler(this.btn_uploadNewVersionAbstractPaper_Click);
            // 
            // btn_uploadAbstractPaper
            // 
            this.btn_uploadAbstractPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_uploadAbstractPaper.Location = new System.Drawing.Point(492, 12);
            this.btn_uploadAbstractPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_uploadAbstractPaper.Name = "btn_uploadAbstractPaper";
            this.btn_uploadAbstractPaper.Size = new System.Drawing.Size(211, 42);
            this.btn_uploadAbstractPaper.TabIndex = 15;
            this.btn_uploadAbstractPaper.Text = "Upload Abstract Paper";
            this.btn_uploadAbstractPaper.UseVisualStyleBackColor = true;
            this.btn_uploadAbstractPaper.Click += new System.EventHandler(this.btn_uploadAbstractPaper_Click);
            // 
            // btn_bidProposal
            // 
            this.btn_bidProposal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_bidProposal.Location = new System.Drawing.Point(492, 294);
            this.btn_bidProposal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_bidProposal.Name = "btn_bidProposal";
            this.btn_bidProposal.Size = new System.Drawing.Size(211, 42);
            this.btn_bidProposal.TabIndex = 13;
            this.btn_bidProposal.Text = "Bid Proposal";
            this.btn_bidProposal.UseVisualStyleBackColor = true;
            this.btn_bidProposal.Click += new System.EventHandler(this.btn_bidProposal_Click);
            // 
            // lbl_cfpOver
            // 
            this.lbl_cfpOver.AutoSize = true;
            this.lbl_cfpOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_cfpOver.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_cfpOver.Location = new System.Drawing.Point(13, 452);
            this.lbl_cfpOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cfpOver.Name = "lbl_cfpOver";
            this.lbl_cfpOver.Size = new System.Drawing.Size(148, 20);
            this.lbl_cfpOver.TabIndex = 17;
            this.lbl_cfpOver.Text = "CFP period is over";
            this.lbl_cfpOver.Visible = false;
            // 
            // btn_Review_Paper
            // 
            this.btn_Review_Paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Review_Paper.Location = new System.Drawing.Point(493, 514);
            this.btn_Review_Paper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Review_Paper.Name = "btn_Review_Paper";
            this.btn_Review_Paper.Size = new System.Drawing.Size(211, 48);
            this.btn_Review_Paper.TabIndex = 18;
            this.btn_Review_Paper.Text = "Review Paper";
            this.btn_Review_Paper.UseVisualStyleBackColor = true;
            this.btn_Review_Paper.Click += new System.EventHandler(this.btn_Review_Paper_Click);
            // 
            // btn_decide_verdict
            // 
            this.btn_decide_verdict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_decide_verdict.Location = new System.Drawing.Point(493, 452);
            this.btn_decide_verdict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_decide_verdict.Name = "btn_decide_verdict";
            this.btn_decide_verdict.Size = new System.Drawing.Size(211, 48);
            this.btn_decide_verdict.TabIndex = 19;
            this.btn_decide_verdict.Text = "Decide Paper Verdict";
            this.btn_decide_verdict.UseVisualStyleBackColor = true;
            this.btn_decide_verdict.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_chat
            // 
            this.btn_chat.Enabled = false;
            this.btn_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_chat.Location = new System.Drawing.Point(493, 576);
            this.btn_chat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(211, 48);
            this.btn_chat.TabIndex = 20;
            this.btn_chat.Text = "Chat";
            this.btn_chat.UseVisualStyleBackColor = true;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            // 
            // btn_organizeSections
            // 
            this.btn_organizeSections.Enabled = false;
            this.btn_organizeSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_organizeSections.Location = new System.Drawing.Point(492, 348);
            this.btn_organizeSections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_organizeSections.Name = "btn_organizeSections";
            this.btn_organizeSections.Size = new System.Drawing.Size(211, 42);
            this.btn_organizeSections.TabIndex = 21;
            this.btn_organizeSections.Text = "Organize Sections";
            this.btn_organizeSections.UseVisualStyleBackColor = true;
            this.btn_organizeSections.Click += new System.EventHandler(this.btn_organizeSections_Click);
            // 
            // btn_viewSchedule
            // 
            this.btn_viewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_viewSchedule.Location = new System.Drawing.Point(492, 398);
            this.btn_viewSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_viewSchedule.Name = "btn_viewSchedule";
            this.btn_viewSchedule.Size = new System.Drawing.Size(211, 42);
            this.btn_viewSchedule.TabIndex = 22;
            this.btn_viewSchedule.Text = "View Schedule";
            this.btn_viewSchedule.UseVisualStyleBackColor = true;
            this.btn_viewSchedule.Click += new System.EventHandler(this.btn_viewSchedule_Click);
            // 
            // btn_assignChairsToSections
            // 
            this.btn_assignChairsToSections.Enabled = false;
            this.btn_assignChairsToSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_assignChairsToSections.Location = new System.Drawing.Point(222, 514);
            this.btn_assignChairsToSections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_assignChairsToSections.Name = "btn_assignChairsToSections";
            this.btn_assignChairsToSections.Size = new System.Drawing.Size(253, 48);
            this.btn_assignChairsToSections.TabIndex = 23;
            this.btn_assignChairsToSections.Text = "Assign Chairs to Sections";
            this.btn_assignChairsToSections.UseVisualStyleBackColor = true;
            this.btn_assignChairsToSections.Click += new System.EventHandler(this.btn_assignChairsToSections_Click);
            // 
            // btn_joinSession
            // 
            this.btn_joinSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_joinSession.Location = new System.Drawing.Point(223, 576);
            this.btn_joinSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_joinSession.Name = "btn_joinSession";
            this.btn_joinSession.Size = new System.Drawing.Size(253, 48);
            this.btn_joinSession.TabIndex = 24;
            this.btn_joinSession.Text = "Join Session";
            this.btn_joinSession.UseVisualStyleBackColor = true;
            this.btn_joinSession.Click += new System.EventHandler(this.btn_joinSession_Click);
            // 
            // btn_Send_Email
            // 
            this.btn_Send_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Send_Email.Location = new System.Drawing.Point(493, 632);
            this.btn_Send_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Send_Email.Name = "btn_Send_Email";
            this.btn_Send_Email.Size = new System.Drawing.Size(211, 48);
            this.btn_Send_Email.TabIndex = 25;
            this.btn_Send_Email.Text = "Send Email";
            this.btn_Send_Email.UseVisualStyleBackColor = true;
            this.btn_Send_Email.Click += new System.EventHandler(this.btn_Send_Email_Click);
            // 
            // btn_upload_presentation
            // 
            this.btn_upload_presentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_upload_presentation.Location = new System.Drawing.Point(222, 632);
            this.btn_upload_presentation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_upload_presentation.Name = "btn_upload_presentation";
            this.btn_upload_presentation.Size = new System.Drawing.Size(253, 48);
            this.btn_upload_presentation.TabIndex = 26;
            this.btn_upload_presentation.Text = "Upload Presentation";
            this.btn_upload_presentation.UseVisualStyleBackColor = true;
            this.btn_upload_presentation.Click += new System.EventHandler(this.btn_upload_presentation_Click);
            // 
            // lbl_periodReview1
            // 
            this.lbl_periodReview1.AutoSize = true;
            this.lbl_periodReview1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_periodReview1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_periodReview1.Location = new System.Drawing.Point(11, 31);
            this.lbl_periodReview1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_periodReview1.Name = "lbl_periodReview1";
            this.lbl_periodReview1.Size = new System.Drawing.Size(114, 20);
            this.lbl_periodReview1.TabIndex = 27;
            this.lbl_periodReview1.Text = "Review period";
            // 
            // lbl_periodBid
            // 
            this.lbl_periodBid.AutoSize = true;
            this.lbl_periodBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_periodBid.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_periodBid.Location = new System.Drawing.Point(11, 6);
            this.lbl_periodBid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_periodBid.Name = "lbl_periodBid";
            this.lbl_periodBid.Size = new System.Drawing.Size(85, 20);
            this.lbl_periodBid.TabIndex = 28;
            this.lbl_periodBid.Text = "Bid period";
            // 
            // lbl_periodOrganization
            // 
            this.lbl_periodOrganization.AutoSize = true;
            this.lbl_periodOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_periodOrganization.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_periodOrganization.Location = new System.Drawing.Point(11, 56);
            this.lbl_periodOrganization.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_periodOrganization.Name = "lbl_periodOrganization";
            this.lbl_periodOrganization.Size = new System.Drawing.Size(155, 20);
            this.lbl_periodOrganization.TabIndex = 29;
            this.lbl_periodOrganization.Text = "Organization period";
            // 
            // pnl_periods
            // 
            this.pnl_periods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_periods.Controls.Add(this.lbl_periodBeforeConference);
            this.pnl_periods.Controls.Add(this.lbl_periodReview2);
            this.pnl_periods.Controls.Add(this.lbl_periodBid);
            this.pnl_periods.Controls.Add(this.lbl_periodOrganization);
            this.pnl_periods.Controls.Add(this.lbl_periodReview1);
            this.pnl_periods.Location = new System.Drawing.Point(12, 484);
            this.pnl_periods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_periods.Name = "pnl_periods";
            this.pnl_periods.Size = new System.Drawing.Size(195, 137);
            this.pnl_periods.TabIndex = 30;
            // 
            // lbl_periodBeforeConference
            // 
            this.lbl_periodBeforeConference.AutoSize = true;
            this.lbl_periodBeforeConference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_periodBeforeConference.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_periodBeforeConference.Location = new System.Drawing.Point(12, 107);
            this.lbl_periodBeforeConference.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_periodBeforeConference.Name = "lbl_periodBeforeConference";
            this.lbl_periodBeforeConference.Size = new System.Drawing.Size(150, 20);
            this.lbl_periodBeforeConference.TabIndex = 31;
            this.lbl_periodBeforeConference.Text = "Before Conference";
            // 
            // lbl_periodReview2
            // 
            this.lbl_periodReview2.AutoSize = true;
            this.lbl_periodReview2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_periodReview2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_periodReview2.Location = new System.Drawing.Point(11, 82);
            this.lbl_periodReview2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_periodReview2.Name = "lbl_periodReview2";
            this.lbl_periodReview2.Size = new System.Drawing.Size(124, 20);
            this.lbl_periodReview2.TabIndex = 30;
            this.lbl_periodReview2.Text = "Second Review";
            // 
            // ConferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 693);
            this.Controls.Add(this.pnl_periods);
            this.Controls.Add(this.btn_upload_presentation);
            this.Controls.Add(this.btn_Send_Email);
            this.Controls.Add(this.btn_joinSession);
            this.Controls.Add(this.btn_assignChairsToSections);
            this.Controls.Add(this.btn_viewSchedule);
            this.Controls.Add(this.btn_organizeSections);
            this.Controls.Add(this.btn_chat);
            this.Controls.Add(this.btn_decide_verdict);
            this.Controls.Add(this.btn_Review_Paper);
            this.Controls.Add(this.lbl_cfpOver);
            this.Controls.Add(this.btn_uploadNewVersionAbstractPaper);
            this.Controls.Add(this.btn_uploadAbstractPaper);
            this.Controls.Add(this.btn_uploadNewPaperVersion);
            this.Controls.Add(this.btn_bidProposal);
            this.Controls.Add(this.btn_paperDetails);
            this.Controls.Add(this.btn_uploadFullPaper);
            this.Controls.Add(this.panel_ConferenceDetails);
            this.Controls.Add(this.btn_postponeConfDead);
            this.Controls.Add(this.btn_back);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conference CMS";
            this.panel_ConferenceDetails.ResumeLayout(false);
            this.panel_ConferenceDetails.PerformLayout();
            this.pnl_periods.ResumeLayout(false);
            this.pnl_periods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_postponeConfDead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_ConferenceDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_organizer;
        private System.Windows.Forms.TextBox txtb_confDesc;
        private System.Windows.Forms.TextBox txtb_confTitle;
        private System.Windows.Forms.Button btn_uploadFullPaper;
        private System.Windows.Forms.Button btn_paperDetails;
        private System.Windows.Forms.Button btn_uploadNewPaperVersion;
        private System.Windows.Forms.Button btn_uploadNewVersionAbstractPaper;
        private System.Windows.Forms.Button btn_uploadAbstractPaper;
        private System.Windows.Forms.DateTimePicker dtp_confEndCFPProp;
        private System.Windows.Forms.DateTimePicker dtp_confStartCFP;
        private System.Windows.Forms.DateTimePicker dtp_confEndDate;
        private System.Windows.Forms.DateTimePicker dtp_confStartDate;
        private System.Windows.Forms.Button btn_bidProposal;
        private System.Windows.Forms.DateTimePicker dtp_confEndCFPPaper;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_cfpOver;
        private System.Windows.Forms.Button btn_Review_Paper;
        private System.Windows.Forms.Button btn_decide_verdict;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.Button btn_organizeSections;
        private System.Windows.Forms.Label lbl_confInProgress;
        private System.Windows.Forms.Button btn_viewSchedule;
        private System.Windows.Forms.Button btn_assignChairsToSections;
        private System.Windows.Forms.Button btn_joinSession;
        private System.Windows.Forms.Button btn_Send_Email;
        private System.Windows.Forms.Button btn_upload_presentation;
        private System.Windows.Forms.Label lbl_periodReview1;
        private System.Windows.Forms.Label lbl_periodBid;
        private System.Windows.Forms.Label lbl_periodOrganization;
        private System.Windows.Forms.Panel pnl_periods;
        private System.Windows.Forms.Label lbl_periodReview2;
        private System.Windows.Forms.Label lbl_periodBeforeConference;
        private System.Windows.Forms.Label lbl_requirePaper;
    }
}