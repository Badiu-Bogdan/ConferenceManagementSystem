
namespace ConferenceManagementSystem.src.main.view
{
    partial class UploadPresentation
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
            this.panel_DragAndDrop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_abstract = new System.Windows.Forms.ComboBox();
            this.btn_Upload_Presentation = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_selectedFile = new System.Windows.Forms.Label();
            this.panel_DragAndDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DragAndDrop
            // 
            this.panel_DragAndDrop.AllowDrop = true;
            this.panel_DragAndDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_DragAndDrop.Controls.Add(this.label1);
            this.panel_DragAndDrop.Location = new System.Drawing.Point(12, 12);
            this.panel_DragAndDrop.Name = "panel_DragAndDrop";
            this.panel_DragAndDrop.Size = new System.Drawing.Size(562, 191);
            this.panel_DragAndDrop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag and Drop your file here (.ppt and .pptx only)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abstract:";
            // 
            // comboBox_abstract
            // 
            this.comboBox_abstract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_abstract.FormattingEnabled = true;
            this.comboBox_abstract.Location = new System.Drawing.Point(95, 242);
            this.comboBox_abstract.Name = "comboBox_abstract";
            this.comboBox_abstract.Size = new System.Drawing.Size(479, 24);
            this.comboBox_abstract.TabIndex = 2;
            this.comboBox_abstract.SelectedIndexChanged += new System.EventHandler(this.comboBox_abstract_SelectedIndexChanged);
            // 
            // btn_Upload_Presentation
            // 
            this.btn_Upload_Presentation.Enabled = false;
            this.btn_Upload_Presentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Upload_Presentation.Location = new System.Drawing.Point(351, 282);
            this.btn_Upload_Presentation.Name = "btn_Upload_Presentation";
            this.btn_Upload_Presentation.Size = new System.Drawing.Size(223, 42);
            this.btn_Upload_Presentation.TabIndex = 3;
            this.btn_Upload_Presentation.Text = "Upload Presentation";
            this.btn_Upload_Presentation.UseVisualStyleBackColor = true;
            this.btn_Upload_Presentation.Click += new System.EventHandler(this.btn_Upload_Presentation_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(12, 282);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(109, 42);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_selectedFile
            // 
            this.lbl_selectedFile.AutoSize = true;
            this.lbl_selectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_selectedFile.Location = new System.Drawing.Point(12, 206);
            this.lbl_selectedFile.Name = "lbl_selectedFile";
            this.lbl_selectedFile.Size = new System.Drawing.Size(126, 20);
            this.lbl_selectedFile.TabIndex = 5;
            this.lbl_selectedFile.Text = "No file detected";
            // 
            // UploadPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 336);
            this.Controls.Add(this.lbl_selectedFile);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Upload_Presentation);
            this.Controls.Add(this.comboBox_abstract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_DragAndDrop);
            this.Name = "UploadPresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadPresentation";
            this.panel_DragAndDrop.ResumeLayout(false);
            this.panel_DragAndDrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_DragAndDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_abstract;
        private System.Windows.Forms.Button btn_Upload_Presentation;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_selectedFile;
    }
}