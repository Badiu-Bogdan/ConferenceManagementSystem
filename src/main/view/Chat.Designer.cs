
namespace ConferenceManagementSystem.src.main.view
{
    partial class Chat
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
            this.cmbox_papers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_chat = new System.Windows.Forms.TextBox();
            this.txtbox_abstractPaper = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_reject = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.txtbox_comment = new System.Windows.Forms.TextBox();
            this.btn_downloadPaper = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbox_papers
            // 
            this.cmbox_papers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_papers.FormattingEnabled = true;
            this.cmbox_papers.Location = new System.Drawing.Point(30, 64);
            this.cmbox_papers.Name = "cmbox_papers";
            this.cmbox_papers.Size = new System.Drawing.Size(335, 24);
            this.cmbox_papers.TabIndex = 21;
            this.cmbox_papers.SelectedIndexChanged += new System.EventHandler(this.cmbox_papers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Paper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Chat";
            // 
            // txtbox_chat
            // 
            this.txtbox_chat.Location = new System.Drawing.Point(399, 54);
            this.txtbox_chat.Multiline = true;
            this.txtbox_chat.Name = "txtbox_chat";
            this.txtbox_chat.ReadOnly = true;
            this.txtbox_chat.Size = new System.Drawing.Size(387, 276);
            this.txtbox_chat.TabIndex = 23;
            // 
            // txtbox_abstractPaper
            // 
            this.txtbox_abstractPaper.Location = new System.Drawing.Point(30, 141);
            this.txtbox_abstractPaper.Multiline = true;
            this.txtbox_abstractPaper.Name = "txtbox_abstractPaper";
            this.txtbox_abstractPaper.ReadOnly = true;
            this.txtbox_abstractPaper.Size = new System.Drawing.Size(335, 199);
            this.txtbox_abstractPaper.TabIndex = 25;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(28, 448);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(112, 42);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_reject
            // 
            this.btn_reject.Enabled = false;
            this.btn_reject.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reject.Location = new System.Drawing.Point(661, 430);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(125, 59);
            this.btn_reject.TabIndex = 27;
            this.btn_reject.Text = "Reject Paper";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Enabled = false;
            this.btn_accept.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.Location = new System.Drawing.Point(530, 429);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(125, 60);
            this.btn_accept.TabIndex = 26;
            this.btn_accept.Text = "Accept Paper";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // txtbox_comment
            // 
            this.txtbox_comment.Enabled = false;
            this.txtbox_comment.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_comment.Location = new System.Drawing.Point(399, 372);
            this.txtbox_comment.Multiline = true;
            this.txtbox_comment.Name = "txtbox_comment";
            this.txtbox_comment.Size = new System.Drawing.Size(387, 41);
            this.txtbox_comment.TabIndex = 29;
            // 
            // btn_downloadPaper
            // 
            this.btn_downloadPaper.Enabled = false;
            this.btn_downloadPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_downloadPaper.Location = new System.Drawing.Point(30, 372);
            this.btn_downloadPaper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_downloadPaper.Name = "btn_downloadPaper";
            this.btn_downloadPaper.Size = new System.Drawing.Size(335, 41);
            this.btn_downloadPaper.TabIndex = 30;
            this.btn_downloadPaper.Text = "Download Full Paper";
            this.btn_downloadPaper.UseVisualStyleBackColor = true;
            this.btn_downloadPaper.Click += new System.EventHandler(this.btn_downloadPaper_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "New Comment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Abstract";
            // 
            // btn_addComment
            // 
            this.btn_addComment.Enabled = false;
            this.btn_addComment.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addComment.Location = new System.Drawing.Point(399, 430);
            this.btn_addComment.Name = "btn_addComment";
            this.btn_addComment.Size = new System.Drawing.Size(125, 59);
            this.btn_addComment.TabIndex = 33;
            this.btn_addComment.Text = "Add Comment";
            this.btn_addComment.UseVisualStyleBackColor = true;
            this.btn_addComment.Click += new System.EventHandler(this.btn_addComment_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 510);
            this.Controls.Add(this.btn_addComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_downloadPaper);
            this.Controls.Add(this.txtbox_comment);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.txtbox_abstractPaper);
            this.Controls.Add(this.txtbox_chat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_papers);
            this.Controls.Add(this.label1);
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbox_papers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_chat;
        private System.Windows.Forms.TextBox txtbox_abstractPaper;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.TextBox txtbox_comment;
        private System.Windows.Forms.Button btn_downloadPaper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addComment;
    }
}