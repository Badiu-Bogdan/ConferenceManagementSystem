
namespace ConferenceManagementSystem.src.main.view
{
    partial class UploadAbstractPaper
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_abstractTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_keywords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_abstractMetaInfo = new System.Windows.Forms.TextBox();
            this.btn_removeAuthor = new System.Windows.Forms.Button();
            this.btn_addAuthor = new System.Windows.Forms.Button();
            this.listbx_authorsSelected = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listbx_authors = new System.Windows.Forms.ListBox();
            this.btn_uploadAbstractPaper = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txtb_abstractPaper = new System.Windows.Forms.TextBox();
            this.btn_removeTopic = new System.Windows.Forms.Button();
            this.btn_addTopic = new System.Windows.Forms.Button();
            this.listbx_topicsSelected = new System.Windows.Forms.ListBox();
            this.listbx_topics = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(462, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Title:";
            // 
            // txtb_abstractTitle
            // 
            this.txtb_abstractTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_abstractTitle.Location = new System.Drawing.Point(573, 27);
            this.txtb_abstractTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_abstractTitle.Name = "txtb_abstractTitle";
            this.txtb_abstractTitle.Size = new System.Drawing.Size(304, 26);
            this.txtb_abstractTitle.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(462, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Keywords:";
            // 
            // txtb_keywords
            // 
            this.txtb_keywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_keywords.Location = new System.Drawing.Point(573, 64);
            this.txtb_keywords.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_keywords.Name = "txtb_keywords";
            this.txtb_keywords.Size = new System.Drawing.Size(304, 26);
            this.txtb_keywords.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(462, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Available Topics:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(462, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Meta-information:";
            // 
            // txtb_abstractMetaInfo
            // 
            this.txtb_abstractMetaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_abstractMetaInfo.Location = new System.Drawing.Point(466, 314);
            this.txtb_abstractMetaInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_abstractMetaInfo.Multiline = true;
            this.txtb_abstractMetaInfo.Name = "txtb_abstractMetaInfo";
            this.txtb_abstractMetaInfo.Size = new System.Drawing.Size(411, 61);
            this.txtb_abstractMetaInfo.TabIndex = 22;
            // 
            // btn_removeAuthor
            // 
            this.btn_removeAuthor.Location = new System.Drawing.Point(422, 493);
            this.btn_removeAuthor.Name = "btn_removeAuthor";
            this.btn_removeAuthor.Size = new System.Drawing.Size(60, 35);
            this.btn_removeAuthor.TabIndex = 30;
            this.btn_removeAuthor.Text = "<";
            this.btn_removeAuthor.UseVisualStyleBackColor = true;
            this.btn_removeAuthor.Click += new System.EventHandler(this.btn_removeAuthor_Click_1);
            // 
            // btn_addAuthor
            // 
            this.btn_addAuthor.Location = new System.Drawing.Point(422, 451);
            this.btn_addAuthor.Name = "btn_addAuthor";
            this.btn_addAuthor.Size = new System.Drawing.Size(60, 36);
            this.btn_addAuthor.TabIndex = 31;
            this.btn_addAuthor.Text = ">";
            this.btn_addAuthor.UseVisualStyleBackColor = true;
            this.btn_addAuthor.Click += new System.EventHandler(this.btn_addAuthor_Click_1);
            // 
            // listbx_authorsSelected
            // 
            this.listbx_authorsSelected.FormattingEnabled = true;
            this.listbx_authorsSelected.ItemHeight = 16;
            this.listbx_authorsSelected.Location = new System.Drawing.Point(518, 432);
            this.listbx_authorsSelected.Name = "listbx_authorsSelected";
            this.listbx_authorsSelected.Size = new System.Drawing.Size(359, 116);
            this.listbx_authorsSelected.Sorted = true;
            this.listbx_authorsSelected.TabIndex = 29;
            this.listbx_authorsSelected.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbx_authorsSelected_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(638, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Selected authors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(104, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Select other authors";
            // 
            // listbx_authors
            // 
            this.listbx_authors.FormattingEnabled = true;
            this.listbx_authors.ItemHeight = 16;
            this.listbx_authors.Location = new System.Drawing.Point(25, 432);
            this.listbx_authors.Name = "listbx_authors";
            this.listbx_authors.Size = new System.Drawing.Size(363, 116);
            this.listbx_authors.Sorted = true;
            this.listbx_authors.TabIndex = 26;
            this.listbx_authors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbx_authors_MouseDoubleClick);
            // 
            // btn_uploadAbstractPaper
            // 
            this.btn_uploadAbstractPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_uploadAbstractPaper.Location = new System.Drawing.Point(679, 581);
            this.btn_uploadAbstractPaper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_uploadAbstractPaper.Name = "btn_uploadAbstractPaper";
            this.btn_uploadAbstractPaper.Size = new System.Drawing.Size(212, 41);
            this.btn_uploadAbstractPaper.TabIndex = 24;
            this.btn_uploadAbstractPaper.Text = "Upload Abstract Paper";
            this.btn_uploadAbstractPaper.UseVisualStyleBackColor = true;
            this.btn_uploadAbstractPaper.Click += new System.EventHandler(this.btn_uploadAbstractPaper_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(13, 581);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // txtb_abstractPaper
            // 
            this.txtb_abstractPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_abstractPaper.Location = new System.Drawing.Point(25, 54);
            this.txtb_abstractPaper.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_abstractPaper.Multiline = true;
            this.txtb_abstractPaper.Name = "txtb_abstractPaper";
            this.txtb_abstractPaper.Size = new System.Drawing.Size(390, 321);
            this.txtb_abstractPaper.TabIndex = 33;
            // 
            // btn_removeTopic
            // 
            this.btn_removeTopic.Location = new System.Drawing.Point(642, 209);
            this.btn_removeTopic.Name = "btn_removeTopic";
            this.btn_removeTopic.Size = new System.Drawing.Size(45, 28);
            this.btn_removeTopic.TabIndex = 36;
            this.btn_removeTopic.Text = "<";
            this.btn_removeTopic.UseVisualStyleBackColor = true;
            this.btn_removeTopic.Click += new System.EventHandler(this.btn_removeTopic_Click_1);
            // 
            // btn_addTopic
            // 
            this.btn_addTopic.Location = new System.Drawing.Point(642, 175);
            this.btn_addTopic.Name = "btn_addTopic";
            this.btn_addTopic.Size = new System.Drawing.Size(45, 28);
            this.btn_addTopic.TabIndex = 37;
            this.btn_addTopic.Text = ">";
            this.btn_addTopic.UseVisualStyleBackColor = true;
            this.btn_addTopic.Click += new System.EventHandler(this.btn_addTopic_Click_1);
            // 
            // listbx_topicsSelected
            // 
            this.listbx_topicsSelected.FormattingEnabled = true;
            this.listbx_topicsSelected.ItemHeight = 16;
            this.listbx_topicsSelected.Location = new System.Drawing.Point(719, 140);
            this.listbx_topicsSelected.Name = "listbx_topicsSelected";
            this.listbx_topicsSelected.Size = new System.Drawing.Size(158, 116);
            this.listbx_topicsSelected.Sorted = true;
            this.listbx_topicsSelected.TabIndex = 34;
            this.listbx_topicsSelected.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbx_topicsSelected_MouseDoubleClick);
            // 
            // listbx_topics
            // 
            this.listbx_topics.FormattingEnabled = true;
            this.listbx_topics.ItemHeight = 16;
            this.listbx_topics.Location = new System.Drawing.Point(466, 140);
            this.listbx_topics.Name = "listbx_topics";
            this.listbx_topics.Size = new System.Drawing.Size(151, 116);
            this.listbx_topics.Sorted = true;
            this.listbx_topics.TabIndex = 35;
            this.listbx_topics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbx_topics_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(715, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Selected Topics:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(166, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Abstract:";
            // 
            // UploadAbstractPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 635);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_removeTopic);
            this.Controls.Add(this.btn_addTopic);
            this.Controls.Add(this.listbx_topicsSelected);
            this.Controls.Add(this.listbx_topics);
            this.Controls.Add(this.txtb_abstractPaper);
            this.Controls.Add(this.btn_removeAuthor);
            this.Controls.Add(this.btn_addAuthor);
            this.Controls.Add(this.listbx_authorsSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listbx_authors);
            this.Controls.Add(this.btn_uploadAbstractPaper);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_abstractMetaInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_keywords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_abstractTitle);
            this.Name = "UploadAbstractPaper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Abstract Paper CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_abstractTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_keywords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_abstractMetaInfo;
        private System.Windows.Forms.Button btn_removeAuthor;
        private System.Windows.Forms.Button btn_addAuthor;
        private System.Windows.Forms.ListBox listbx_authorsSelected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listbx_authors;
        private System.Windows.Forms.Button btn_uploadAbstractPaper;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtb_abstractPaper;
        private System.Windows.Forms.Button btn_removeTopic;
        private System.Windows.Forms.Button btn_addTopic;
        private System.Windows.Forms.ListBox listbx_topicsSelected;
        private System.Windows.Forms.ListBox listbx_topics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}