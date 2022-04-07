
namespace ConferenceManagementSystem.src.main.view
{
    partial class UploadNewAbstractVersion
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_uploadNewPaperVersion = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txtb_abstractPaper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbox_papers
            // 
            this.cmbox_papers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_papers.FormattingEnabled = true;
            this.cmbox_papers.Location = new System.Drawing.Point(23, 397);
            this.cmbox_papers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbox_papers.Name = "cmbox_papers";
            this.cmbox_papers.Size = new System.Drawing.Size(370, 24);
            this.cmbox_papers.TabIndex = 23;
            this.cmbox_papers.SelectedIndexChanged += new System.EventHandler(this.cmbox_papers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Choose proposal";
            // 
            // btn_uploadNewPaperVersion
            // 
            this.btn_uploadNewPaperVersion.Enabled = false;
            this.btn_uploadNewPaperVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_uploadNewPaperVersion.Location = new System.Drawing.Point(132, 444);
            this.btn_uploadNewPaperVersion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_uploadNewPaperVersion.Name = "btn_uploadNewPaperVersion";
            this.btn_uploadNewPaperVersion.Size = new System.Drawing.Size(261, 41);
            this.btn_uploadNewPaperVersion.TabIndex = 19;
            this.btn_uploadNewPaperVersion.Text = "Upload New Abstract Version";
            this.btn_uploadNewPaperVersion.UseVisualStyleBackColor = true;
            this.btn_uploadNewPaperVersion.Click += new System.EventHandler(this.btn_uploadNewPaperVersion_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(23, 444);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtb_abstractPaper
            // 
            this.txtb_abstractPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_abstractPaper.Location = new System.Drawing.Point(23, 50);
            this.txtb_abstractPaper.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_abstractPaper.Multiline = true;
            this.txtb_abstractPaper.Name = "txtb_abstractPaper";
            this.txtb_abstractPaper.Size = new System.Drawing.Size(370, 294);
            this.txtb_abstractPaper.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Abstract";
            // 
            // UploadNewAbstractVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_abstractPaper);
            this.Controls.Add(this.cmbox_papers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_uploadNewPaperVersion);
            this.Controls.Add(this.btn_back);
            this.Name = "UploadNewAbstractVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload New Abstract Version CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbox_papers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_uploadNewPaperVersion;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtb_abstractPaper;
        private System.Windows.Forms.Label label1;
    }
}