
namespace ConferenceManagementSystem.src.main.view
{
    partial class UploadFullPaper
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
            this.btn_organizeConference = new System.Windows.Forms.Button();
            this.btn_uploadFullPaper = new System.Windows.Forms.Button();
            this.panel_DragDrop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_selectedFile = new System.Windows.Forms.Label();
            this.txtb_paperTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbox_proposals = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_DragDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_organizeConference
            // 
            this.btn_organizeConference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_organizeConference.Location = new System.Drawing.Point(13, 346);
            this.btn_organizeConference.Margin = new System.Windows.Forms.Padding(4);
            this.btn_organizeConference.Name = "btn_organizeConference";
            this.btn_organizeConference.Size = new System.Drawing.Size(85, 41);
            this.btn_organizeConference.TabIndex = 9;
            this.btn_organizeConference.Text = "Back";
            this.btn_organizeConference.UseVisualStyleBackColor = true;
            this.btn_organizeConference.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_uploadFullPaper
            // 
            this.btn_uploadFullPaper.Enabled = false;
            this.btn_uploadFullPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_uploadFullPaper.Location = new System.Drawing.Point(377, 346);
            this.btn_uploadFullPaper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_uploadFullPaper.Name = "btn_uploadFullPaper";
            this.btn_uploadFullPaper.Size = new System.Drawing.Size(179, 41);
            this.btn_uploadFullPaper.TabIndex = 9;
            this.btn_uploadFullPaper.Text = "Upload Full Paper";
            this.btn_uploadFullPaper.UseVisualStyleBackColor = true;
            this.btn_uploadFullPaper.Click += new System.EventHandler(this.button_uploadFullPaper_Click);
            // 
            // panel_DragDrop
            // 
            this.panel_DragDrop.AllowDrop = true;
            this.panel_DragDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_DragDrop.Controls.Add(this.label1);
            this.panel_DragDrop.Location = new System.Drawing.Point(13, 12);
            this.panel_DragDrop.Name = "panel_DragDrop";
            this.panel_DragDrop.Size = new System.Drawing.Size(543, 196);
            this.panel_DragDrop.TabIndex = 12;
            this.panel_DragDrop.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Drag and Drop your file here (.pdf and .docx only)";
            // 
            // lbl_selectedFile
            // 
            this.lbl_selectedFile.AutoSize = true;
            this.lbl_selectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_selectedFile.Location = new System.Drawing.Point(13, 211);
            this.lbl_selectedFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectedFile.Name = "lbl_selectedFile";
            this.lbl_selectedFile.Size = new System.Drawing.Size(126, 20);
            this.lbl_selectedFile.TabIndex = 13;
            this.lbl_selectedFile.Text = "No file detected";
            // 
            // txtb_paperTitle
            // 
            this.txtb_paperTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_paperTitle.Location = new System.Drawing.Point(103, 240);
            this.txtb_paperTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_paperTitle.Name = "txtb_paperTitle";
            this.txtb_paperTitle.Size = new System.Drawing.Size(453, 26);
            this.txtb_paperTitle.TabIndex = 14;
            this.txtb_paperTitle.TextChanged += new System.EventHandler(this.txtb_paperTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Proposal: ";
            // 
            // cmbox_proposals
            // 
            this.cmbox_proposals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_proposals.FormattingEnabled = true;
            this.cmbox_proposals.Location = new System.Drawing.Point(105, 279);
            this.cmbox_proposals.Name = "cmbox_proposals";
            this.cmbox_proposals.Size = new System.Drawing.Size(234, 24);
            this.cmbox_proposals.TabIndex = 17;
            this.cmbox_proposals.SelectedIndexChanged += new System.EventHandler(this.cmbox_proposals_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(13, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "(Only proposals without papers are available)";
            // 
            // UploadFullPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 400);
            this.Controls.Add(this.cmbox_proposals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_paperTitle);
            this.Controls.Add(this.lbl_selectedFile);
            this.Controls.Add(this.panel_DragDrop);
            this.Controls.Add(this.btn_uploadFullPaper);
            this.Controls.Add(this.btn_organizeConference);
            this.Name = "UploadFullPaper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Full Paper CMS";
            this.panel_DragDrop.ResumeLayout(false);
            this.panel_DragDrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_organizeConference;
        private System.Windows.Forms.Button btn_uploadFullPaper;
        private System.Windows.Forms.Panel panel_DragDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_selectedFile;
        private System.Windows.Forms.TextBox txtb_paperTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbox_proposals;
        private System.Windows.Forms.Label label4;
    }
}