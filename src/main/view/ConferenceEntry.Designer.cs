
namespace ConferenceManagementSystem.src.main.view
{
    partial class ConferenceEntry
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
            this.btn_downloadPaper = new System.Windows.Forms.Button();
            this.cmbox_papers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_noPaperForProposal = new System.Windows.Forms.Label();
            this.btn_download_pres = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_abstractPaper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_keywords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_topics = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_metainfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_authors = new System.Windows.Forms.TextBox();
            this.lbl_isAccepted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(19, 446);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_downloadPaper
            // 
            this.btn_downloadPaper.Enabled = false;
            this.btn_downloadPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_downloadPaper.Location = new System.Drawing.Point(107, 446);
            this.btn_downloadPaper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_downloadPaper.Name = "btn_downloadPaper";
            this.btn_downloadPaper.Size = new System.Drawing.Size(177, 41);
            this.btn_downloadPaper.TabIndex = 9;
            this.btn_downloadPaper.Text = "Download Paper";
            this.btn_downloadPaper.UseVisualStyleBackColor = true;
            this.btn_downloadPaper.Click += new System.EventHandler(this.btn_downloadPaper_Click);
            // 
            // cmbox_papers
            // 
            this.cmbox_papers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_papers.FormattingEnabled = true;
            this.cmbox_papers.Location = new System.Drawing.Point(19, 74);
            this.cmbox_papers.Name = "cmbox_papers";
            this.cmbox_papers.Size = new System.Drawing.Size(265, 24);
            this.cmbox_papers.TabIndex = 11;
            this.cmbox_papers.SelectedIndexChanged += new System.EventHandler(this.cmbox_papers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select a proposal";
            // 
            // lbl_noPaperForProposal
            // 
            this.lbl_noPaperForProposal.AutoSize = true;
            this.lbl_noPaperForProposal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_noPaperForProposal.Location = new System.Drawing.Point(19, 9);
            this.lbl_noPaperForProposal.Name = "lbl_noPaperForProposal";
            this.lbl_noPaperForProposal.Size = new System.Drawing.Size(403, 18);
            this.lbl_noPaperForProposal.TabIndex = 13;
            this.lbl_noPaperForProposal.Text = "The selected proposal does not have any papers associated";
            this.lbl_noPaperForProposal.Visible = false;
            // 
            // btn_download_pres
            // 
            this.btn_download_pres.Enabled = false;
            this.btn_download_pres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_download_pres.Location = new System.Drawing.Point(19, 397);
            this.btn_download_pres.Margin = new System.Windows.Forms.Padding(4);
            this.btn_download_pres.Name = "btn_download_pres";
            this.btn_download_pres.Size = new System.Drawing.Size(265, 41);
            this.btn_download_pres.TabIndex = 14;
            this.btn_download_pres.Text = "Download Presentation";
            this.btn_download_pres.UseVisualStyleBackColor = true;
            this.btn_download_pres.Click += new System.EventHandler(this.btn_download_pres_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Abstract";
            // 
            // txtbox_abstractPaper
            // 
            this.txtbox_abstractPaper.Location = new System.Drawing.Point(19, 155);
            this.txtbox_abstractPaper.Multiline = true;
            this.txtbox_abstractPaper.Name = "txtbox_abstractPaper";
            this.txtbox_abstractPaper.ReadOnly = true;
            this.txtbox_abstractPaper.Size = new System.Drawing.Size(265, 219);
            this.txtbox_abstractPaper.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Keywords:";
            // 
            // txtbox_keywords
            // 
            this.txtbox_keywords.Location = new System.Drawing.Point(312, 74);
            this.txtbox_keywords.Name = "txtbox_keywords";
            this.txtbox_keywords.ReadOnly = true;
            this.txtbox_keywords.Size = new System.Drawing.Size(268, 22);
            this.txtbox_keywords.TabIndex = 36;
            this.txtbox_keywords.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Selected Topics:";
            // 
            // txtbox_topics
            // 
            this.txtbox_topics.Location = new System.Drawing.Point(312, 155);
            this.txtbox_topics.Multiline = true;
            this.txtbox_topics.Name = "txtbox_topics";
            this.txtbox_topics.ReadOnly = true;
            this.txtbox_topics.Size = new System.Drawing.Size(274, 79);
            this.txtbox_topics.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Meta-information:";
            // 
            // txtbox_metainfo
            // 
            this.txtbox_metainfo.Location = new System.Drawing.Point(312, 284);
            this.txtbox_metainfo.Multiline = true;
            this.txtbox_metainfo.Name = "txtbox_metainfo";
            this.txtbox_metainfo.ReadOnly = true;
            this.txtbox_metainfo.Size = new System.Drawing.Size(274, 63);
            this.txtbox_metainfo.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "All Authors:";
            // 
            // txtbox_authors
            // 
            this.txtbox_authors.Location = new System.Drawing.Point(312, 397);
            this.txtbox_authors.Multiline = true;
            this.txtbox_authors.Name = "txtbox_authors";
            this.txtbox_authors.ReadOnly = true;
            this.txtbox_authors.Size = new System.Drawing.Size(274, 90);
            this.txtbox_authors.TabIndex = 42;
            // 
            // lbl_isAccepted
            // 
            this.lbl_isAccepted.AutoSize = true;
            this.lbl_isAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_isAccepted.Location = new System.Drawing.Point(134, 122);
            this.lbl_isAccepted.Name = "lbl_isAccepted";
            this.lbl_isAccepted.Size = new System.Drawing.Size(119, 18);
            this.lbl_isAccepted.TabIndex = 43;
            this.lbl_isAccepted.Text = "Not yet accepted";
            this.lbl_isAccepted.Visible = false;
            // 
            // ConferenceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 516);
            this.Controls.Add(this.lbl_isAccepted);
            this.Controls.Add(this.txtbox_authors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_metainfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_topics);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_keywords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_abstractPaper);
            this.Controls.Add(this.btn_download_pres);
            this.Controls.Add(this.lbl_noPaperForProposal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_papers);
            this.Controls.Add(this.btn_downloadPaper);
            this.Controls.Add(this.btn_back);
            this.Name = "ConferenceEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conference Entry CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_downloadPaper;
        private System.Windows.Forms.ComboBox cmbox_papers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_noPaperForProposal;
        private System.Windows.Forms.Button btn_download_pres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_abstractPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_keywords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_topics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_metainfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_authors;
        private System.Windows.Forms.Label lbl_isAccepted;
    }
}