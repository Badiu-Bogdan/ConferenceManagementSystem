
namespace ConferenceManagementSystem.src.main.view
{
    partial class UploadNewPaperVersion
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
            this.btn_uploadNewPaperVersion = new System.Windows.Forms.Button();
            this.panel_DragDrop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_selectedFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_papers = new System.Windows.Forms.ComboBox();
            this.lbl_noPaperForAbstract = new System.Windows.Forms.Label();
            this.panel_DragDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(13, 362);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_uploadNewPaperVersion
            // 
            this.btn_uploadNewPaperVersion.Enabled = false;
            this.btn_uploadNewPaperVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_uploadNewPaperVersion.Location = new System.Drawing.Point(324, 362);
            this.btn_uploadNewPaperVersion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_uploadNewPaperVersion.Name = "btn_uploadNewPaperVersion";
            this.btn_uploadNewPaperVersion.Size = new System.Drawing.Size(232, 41);
            this.btn_uploadNewPaperVersion.TabIndex = 10;
            this.btn_uploadNewPaperVersion.Text = "Upload New Paper Version";
            this.btn_uploadNewPaperVersion.UseVisualStyleBackColor = true;
            this.btn_uploadNewPaperVersion.Click += new System.EventHandler(this.btn_uploadNewPaperVersion_Click);
            // 
            // panel_DragDrop
            // 
            this.panel_DragDrop.AllowDrop = true;
            this.panel_DragDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_DragDrop.Controls.Add(this.label1);
            this.panel_DragDrop.Location = new System.Drawing.Point(13, 12);
            this.panel_DragDrop.Name = "panel_DragDrop";
            this.panel_DragDrop.Size = new System.Drawing.Size(543, 196);
            this.panel_DragDrop.TabIndex = 13;
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
            this.lbl_selectedFile.Location = new System.Drawing.Point(18, 211);
            this.lbl_selectedFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectedFile.Name = "lbl_selectedFile";
            this.lbl_selectedFile.Size = new System.Drawing.Size(126, 20);
            this.lbl_selectedFile.TabIndex = 14;
            this.lbl_selectedFile.Text = "No file detected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(18, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose proposal";
            // 
            // cmbox_papers
            // 
            this.cmbox_papers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_papers.FormattingEnabled = true;
            this.cmbox_papers.Location = new System.Drawing.Point(22, 273);
            this.cmbox_papers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbox_papers.Name = "cmbox_papers";
            this.cmbox_papers.Size = new System.Drawing.Size(322, 24);
            this.cmbox_papers.TabIndex = 17;
            this.cmbox_papers.SelectedIndexChanged += new System.EventHandler(this.cmbox_papers_SelectedIndexChanged);
            // 
            // lbl_noPaperForAbstract
            // 
            this.lbl_noPaperForAbstract.AutoSize = true;
            this.lbl_noPaperForAbstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_noPaperForAbstract.Location = new System.Drawing.Point(18, 314);
            this.lbl_noPaperForAbstract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_noPaperForAbstract.Name = "lbl_noPaperForAbstract";
            this.lbl_noPaperForAbstract.Size = new System.Drawing.Size(600, 25);
            this.lbl_noPaperForAbstract.TabIndex = 18;
            this.lbl_noPaperForAbstract.Text = "Selected proposal does not have an associated paper uploaded";
            this.lbl_noPaperForAbstract.Visible = false;
            // 
            // UploadNewPaperVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 416);
            this.Controls.Add(this.lbl_noPaperForAbstract);
            this.Controls.Add(this.cmbox_papers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_selectedFile);
            this.Controls.Add(this.panel_DragDrop);
            this.Controls.Add(this.btn_uploadNewPaperVersion);
            this.Controls.Add(this.btn_back);
            this.Name = "UploadNewPaperVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload New Paper Version CMS";
            this.panel_DragDrop.ResumeLayout(false);
            this.panel_DragDrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_uploadNewPaperVersion;
        private System.Windows.Forms.Panel panel_DragDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_selectedFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_papers;
        private System.Windows.Forms.Label lbl_noPaperForAbstract;
    }
}