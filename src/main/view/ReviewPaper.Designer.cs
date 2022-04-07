
namespace ConferenceManagementSystem.src.main.view
{
    partial class ReviewPaper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_downloadPaper = new System.Windows.Forms.Button();
            this.txtbox_abstractPaper = new System.Windows.Forms.TextBox();
            this.txtBox_comment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Review_Paper = new System.Windows.Forms.Button();
            this.cmbox_reviews = new System.Windows.Forms.ComboBox();
            this.cmbox_papers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Paper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a Corresponding Review";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Abstract";
            // 
            // btn_downloadPaper
            // 
            this.btn_downloadPaper.Enabled = false;
            this.btn_downloadPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_downloadPaper.Location = new System.Drawing.Point(49, 399);
            this.btn_downloadPaper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_downloadPaper.Name = "btn_downloadPaper";
            this.btn_downloadPaper.Size = new System.Drawing.Size(318, 41);
            this.btn_downloadPaper.TabIndex = 10;
            this.btn_downloadPaper.Text = "Download Full Paper";
            this.btn_downloadPaper.UseVisualStyleBackColor = true;
            this.btn_downloadPaper.Click += new System.EventHandler(this.btn_downloadPaper_Click);
            // 
            // txtbox_abstractPaper
            // 
            this.txtbox_abstractPaper.Location = new System.Drawing.Point(49, 166);
            this.txtbox_abstractPaper.Multiline = true;
            this.txtbox_abstractPaper.Name = "txtbox_abstractPaper";
            this.txtbox_abstractPaper.ReadOnly = true;
            this.txtbox_abstractPaper.Size = new System.Drawing.Size(312, 199);
            this.txtbox_abstractPaper.TabIndex = 11;
            // 
            // txtBox_comment
            // 
            this.txtBox_comment.Location = new System.Drawing.Point(52, 596);
            this.txtBox_comment.Multiline = true;
            this.txtBox_comment.Name = "txtBox_comment";
            this.txtBox_comment.Size = new System.Drawing.Size(316, 93);
            this.txtBox_comment.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Comments and Improvement Tips";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(52, 708);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_Review_Paper
            // 
            this.btn_Review_Paper.Enabled = false;
            this.btn_Review_Paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Review_Paper.Location = new System.Drawing.Point(221, 708);
            this.btn_Review_Paper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Review_Paper.Name = "btn_Review_Paper";
            this.btn_Review_Paper.Size = new System.Drawing.Size(146, 41);
            this.btn_Review_Paper.TabIndex = 15;
            this.btn_Review_Paper.Text = "Review Paper";
            this.btn_Review_Paper.UseVisualStyleBackColor = true;
            this.btn_Review_Paper.Click += new System.EventHandler(this.btn_Review_Paper_Click);
            // 
            // cmbox_reviews
            // 
            this.cmbox_reviews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_reviews.Enabled = false;
            this.cmbox_reviews.FormattingEnabled = true;
            this.cmbox_reviews.Location = new System.Drawing.Point(49, 511);
            this.cmbox_reviews.Name = "cmbox_reviews";
            this.cmbox_reviews.Size = new System.Drawing.Size(319, 24);
            this.cmbox_reviews.TabIndex = 16;
            this.cmbox_reviews.SelectedIndexChanged += new System.EventHandler(this.cmbox_reviews_SelectedIndexChanged);
            // 
            // cmbox_papers
            // 
            this.cmbox_papers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_papers.FormattingEnabled = true;
            this.cmbox_papers.Location = new System.Drawing.Point(49, 78);
            this.cmbox_papers.Name = "cmbox_papers";
            this.cmbox_papers.Size = new System.Drawing.Size(312, 24);
            this.cmbox_papers.TabIndex = 17;
            this.cmbox_papers.SelectedIndexChanged += new System.EventHandler(this.cmbox_papers_SelectedIndexChanged);
            // 
            // ReviewPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 771);
            this.Controls.Add(this.cmbox_papers);
            this.Controls.Add(this.cmbox_reviews);
            this.Controls.Add(this.btn_Review_Paper);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_comment);
            this.Controls.Add(this.txtbox_abstractPaper);
            this.Controls.Add(this.btn_downloadPaper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReviewPaper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewPaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_downloadPaper;
        private System.Windows.Forms.TextBox txtbox_abstractPaper;
        private System.Windows.Forms.TextBox txtBox_comment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Review_Paper;
        private System.Windows.Forms.ComboBox cmbox_reviews;
        private System.Windows.Forms.ComboBox cmbox_papers;
    }
}