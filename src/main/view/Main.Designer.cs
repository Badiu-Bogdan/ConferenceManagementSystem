namespace ConferenceManagementSystem.src.main.view
{
    partial class Main
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel_tbd = new System.Windows.Forms.Panel();
            this.btn_invitePCMembers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_organizeConfEd = new System.Windows.Forms.Button();
            this.btn_chooseChairForConf = new System.Windows.Forms.Button();
            this.cmbx_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_goToConference = new System.Windows.Forms.Button();
            this.cmbox_conferences = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_payRegistrationFee = new System.Windows.Forms.Button();
            this.btn_assign_reviewers_to_paper = new System.Windows.Forms.Button();
            this.panel_tbd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(11, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(233, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Logged in as: <username>";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_logout.Location = new System.Drawing.Point(565, 6);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(115, 33);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel_tbd
            // 
            this.panel_tbd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_tbd.Controls.Add(this.btn_invitePCMembers);
            this.panel_tbd.Controls.Add(this.label2);
            this.panel_tbd.Controls.Add(this.btn_organizeConfEd);
            this.panel_tbd.Controls.Add(this.btn_chooseChairForConf);
            this.panel_tbd.Location = new System.Drawing.Point(16, 73);
            this.panel_tbd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel_tbd.Name = "panel_tbd";
            this.panel_tbd.Size = new System.Drawing.Size(393, 260);
            this.panel_tbd.TabIndex = 6;
            // 
            // btn_invitePCMembers
            // 
            this.btn_invitePCMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_invitePCMembers.Location = new System.Drawing.Point(31, 191);
            this.btn_invitePCMembers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_invitePCMembers.Name = "btn_invitePCMembers";
            this.btn_invitePCMembers.Size = new System.Drawing.Size(325, 36);
            this.btn_invitePCMembers.TabIndex = 7;
            this.btn_invitePCMembers.Text = "Invite PC Members";
            this.btn_invitePCMembers.UseVisualStyleBackColor = true;
            this.btn_invitePCMembers.Click += new System.EventHandler(this.btn_invitePCMembers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(28, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "For type of account: Steering Committee Member";
            // 
            // btn_organizeConfEd
            // 
            this.btn_organizeConfEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_organizeConfEd.Location = new System.Drawing.Point(31, 60);
            this.btn_organizeConfEd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_organizeConfEd.Name = "btn_organizeConfEd";
            this.btn_organizeConfEd.Size = new System.Drawing.Size(325, 36);
            this.btn_organizeConfEd.TabIndex = 5;
            this.btn_organizeConfEd.Text = "Organize Conference Edition";
            this.btn_organizeConfEd.UseVisualStyleBackColor = true;
            this.btn_organizeConfEd.Click += new System.EventHandler(this.btn_organizeConfEd_Click);
            // 
            // btn_chooseChairForConf
            // 
            this.btn_chooseChairForConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_chooseChairForConf.Location = new System.Drawing.Point(31, 129);
            this.btn_chooseChairForConf.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_chooseChairForConf.Name = "btn_chooseChairForConf";
            this.btn_chooseChairForConf.Size = new System.Drawing.Size(325, 36);
            this.btn_chooseChairForConf.TabIndex = 5;
            this.btn_chooseChairForConf.Text = "Choose Chair For Conference";
            this.btn_chooseChairForConf.UseVisualStyleBackColor = true;
            this.btn_chooseChairForConf.Click += new System.EventHandler(this.btn_chooseChairForConf_Click);
            // 
            // cmbx_type
            // 
            this.cmbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_type.FormattingEnabled = true;
            this.cmbx_type.Location = new System.Drawing.Point(521, 401);
            this.cmbx_type.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbx_type.Name = "cmbx_type";
            this.cmbx_type.Size = new System.Drawing.Size(159, 24);
            this.cmbx_type.TabIndex = 8;
            this.cmbx_type.SelectedIndexChanged += new System.EventHandler(this.cmbx_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose type of account:";
            // 
            // btn_goToConference
            // 
            this.btn_goToConference.Enabled = false;
            this.btn_goToConference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_goToConference.Location = new System.Drawing.Point(432, 126);
            this.btn_goToConference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_goToConference.Name = "btn_goToConference";
            this.btn_goToConference.Size = new System.Drawing.Size(248, 44);
            this.btn_goToConference.TabIndex = 5;
            this.btn_goToConference.Text = "Go to conference";
            this.btn_goToConference.UseVisualStyleBackColor = true;
            this.btn_goToConference.Click += new System.EventHandler(this.btn_goToConference_Click);
            // 
            // cmbox_conferences
            // 
            this.cmbox_conferences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_conferences.FormattingEnabled = true;
            this.cmbox_conferences.Location = new System.Drawing.Point(432, 91);
            this.cmbox_conferences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbox_conferences.Name = "cmbox_conferences";
            this.cmbox_conferences.Size = new System.Drawing.Size(248, 24);
            this.cmbox_conferences.TabIndex = 10;
            this.cmbox_conferences.SelectedIndexChanged += new System.EventHandler(this.cmbox_conferences_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(429, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select a conference";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(429, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select a conference:";
            // 
            // btn_payRegistrationFee
            // 
            this.btn_payRegistrationFee.Enabled = false;
            this.btn_payRegistrationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_payRegistrationFee.Location = new System.Drawing.Point(432, 176);
            this.btn_payRegistrationFee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_payRegistrationFee.Name = "btn_payRegistrationFee";
            this.btn_payRegistrationFee.Size = new System.Drawing.Size(248, 42);
            this.btn_payRegistrationFee.TabIndex = 12;
            this.btn_payRegistrationFee.Text = "Pay the Registration Fee";
            this.btn_payRegistrationFee.UseVisualStyleBackColor = true;
            this.btn_payRegistrationFee.Click += new System.EventHandler(this.button_payRegistrationFee_Click);
            // 
            // btn_assign_reviewers_to_paper
            // 
            this.btn_assign_reviewers_to_paper.Enabled = false;
            this.btn_assign_reviewers_to_paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_assign_reviewers_to_paper.Location = new System.Drawing.Point(432, 226);
            this.btn_assign_reviewers_to_paper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_assign_reviewers_to_paper.Name = "btn_assign_reviewers_to_paper";
            this.btn_assign_reviewers_to_paper.Size = new System.Drawing.Size(248, 42);
            this.btn_assign_reviewers_to_paper.TabIndex = 12;
            this.btn_assign_reviewers_to_paper.Text = "Assign reviewers to papers";
            this.btn_assign_reviewers_to_paper.UseVisualStyleBackColor = true;
            this.btn_assign_reviewers_to_paper.Click += new System.EventHandler(this.btn_assign_reviewers_to_paper_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 436);
            this.Controls.Add(this.btn_assign_reviewers_to_paper);
            this.Controls.Add(this.btn_payRegistrationFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbox_conferences);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_type);
            this.Controls.Add(this.panel_tbd);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_goToConference);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main CMS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_tbd.ResumeLayout(false);
            this.panel_tbd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel_tbd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_organizeConfEd;
        private System.Windows.Forms.ComboBox cmbx_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chooseChairForConf;
        private System.Windows.Forms.Button btn_goToConference;
        private System.Windows.Forms.ComboBox cmbox_conferences;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_payRegistrationFee;
        private System.Windows.Forms.Button btn_assign_reviewers_to_paper;
        private System.Windows.Forms.Button btn_invitePCMembers;
    }
}