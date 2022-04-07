
namespace ConferenceManagementSystem.src.main.view
{
    partial class DecidePaperVerdict
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
            this.cmbox_papers = new System.Windows.Forms.ComboBox();
            this.btn_new_eval = new System.Windows.Forms.Button();
            this.btn_request_discussion = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.accept_btn = new System.Windows.Forms.Button();
            this.reject_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Paper";
            // 
            // cmbox_papers
            // 
            this.cmbox_papers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_papers.FormattingEnabled = true;
            this.cmbox_papers.Location = new System.Drawing.Point(24, 67);
            this.cmbox_papers.Name = "cmbox_papers";
            this.cmbox_papers.Size = new System.Drawing.Size(543, 24);
            this.cmbox_papers.TabIndex = 19;
            this.cmbox_papers.SelectedIndexChanged += new System.EventHandler(this.cmbox_papers_SelectedIndexChanged);
            // 
            // btn_new_eval
            // 
            this.btn_new_eval.Enabled = false;
            this.btn_new_eval.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_eval.Location = new System.Drawing.Point(24, 120);
            this.btn_new_eval.Name = "btn_new_eval";
            this.btn_new_eval.Size = new System.Drawing.Size(118, 88);
            this.btn_new_eval.TabIndex = 20;
            this.btn_new_eval.Text = "Request New Evaluation";
            this.btn_new_eval.UseVisualStyleBackColor = true;
            this.btn_new_eval.Click += new System.EventHandler(this.btn_new_eval_Click);
            // 
            // btn_request_discussion
            // 
            this.btn_request_discussion.Enabled = false;
            this.btn_request_discussion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_request_discussion.Location = new System.Drawing.Point(449, 120);
            this.btn_request_discussion.Name = "btn_request_discussion";
            this.btn_request_discussion.Size = new System.Drawing.Size(118, 88);
            this.btn_request_discussion.TabIndex = 21;
            this.btn_request_discussion.Text = "Request Reviewers Discussion";
            this.btn_request_discussion.UseVisualStyleBackColor = true;
            this.btn_request_discussion.Click += new System.EventHandler(this.btn_request_discussion_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(24, 232);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(112, 42);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // accept_btn
            // 
            this.accept_btn.Enabled = false;
            this.accept_btn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_btn.Location = new System.Drawing.Point(160, 120);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(118, 88);
            this.accept_btn.TabIndex = 23;
            this.accept_btn.Text = "Accept Paper";
            this.accept_btn.UseVisualStyleBackColor = true;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            // 
            // reject_btn
            // 
            this.reject_btn.Enabled = false;
            this.reject_btn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject_btn.Location = new System.Drawing.Point(304, 120);
            this.reject_btn.Name = "reject_btn";
            this.reject_btn.Size = new System.Drawing.Size(118, 88);
            this.reject_btn.TabIndex = 24;
            this.reject_btn.Text = "Reject Paper";
            this.reject_btn.UseVisualStyleBackColor = true;
            this.reject_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DecidePaperVerdict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 292);
            this.Controls.Add(this.reject_btn);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_request_discussion);
            this.Controls.Add(this.btn_new_eval);
            this.Controls.Add(this.cmbox_papers);
            this.Controls.Add(this.label1);
            this.Name = "DecidePaperVerdict";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecidePaperVerdict";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_papers;
        private System.Windows.Forms.Button btn_new_eval;
        private System.Windows.Forms.Button btn_request_discussion;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button accept_btn;
        private System.Windows.Forms.Button reject_btn;
    }
}