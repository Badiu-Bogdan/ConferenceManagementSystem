
namespace ConferenceManagementSystem.src.main.view
{
    partial class InvitePCMembers
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbox_conferences = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_users = new System.Windows.Forms.ComboBox();
            this.btn_invite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(15, 212);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select a conference:";
            // 
            // cmbox_conferences
            // 
            this.cmbox_conferences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_conferences.FormattingEnabled = true;
            this.cmbox_conferences.Location = new System.Drawing.Point(15, 41);
            this.cmbox_conferences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbox_conferences.Name = "cmbox_conferences";
            this.cmbox_conferences.Size = new System.Drawing.Size(460, 24);
            this.cmbox_conferences.TabIndex = 12;
            this.cmbox_conferences.SelectedIndexChanged += new System.EventHandler(this.cmbox_conferences_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select a user";
            // 
            // cmbx_users
            // 
            this.cmbx_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_users.FormattingEnabled = true;
            this.cmbx_users.Location = new System.Drawing.Point(15, 117);
            this.cmbx_users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbx_users.Name = "cmbx_users";
            this.cmbx_users.Size = new System.Drawing.Size(460, 24);
            this.cmbx_users.TabIndex = 15;
            this.cmbx_users.SelectedIndexChanged += new System.EventHandler(this.cmbx_users_SelectedIndexChanged);
            // 
            // btn_invite
            // 
            this.btn_invite.Enabled = false;
            this.btn_invite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_invite.Location = new System.Drawing.Point(390, 212);
            this.btn_invite.Margin = new System.Windows.Forms.Padding(4);
            this.btn_invite.Name = "btn_invite";
            this.btn_invite.Size = new System.Drawing.Size(85, 41);
            this.btn_invite.TabIndex = 16;
            this.btn_invite.Text = "Invite";
            this.btn_invite.UseVisualStyleBackColor = true;
            this.btn_invite.Click += new System.EventHandler(this.btn_invite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Note: You must be a chair for the selected conference";
            // 
            // InvitePCMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_invite);
            this.Controls.Add(this.cmbx_users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbox_conferences);
            this.Controls.Add(this.btn_back);
            this.Name = "InvitePCMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvitePCMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbox_conferences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_users;
        private System.Windows.Forms.Button btn_invite;
        private System.Windows.Forms.Label label2;
    }
}