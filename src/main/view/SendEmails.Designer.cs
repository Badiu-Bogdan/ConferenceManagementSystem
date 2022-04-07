
namespace ConferenceManagementSystem.src.main.view
{
    partial class SendEmails
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
            this.comboBox_authors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_subject = new System.Windows.Forms.TextBox();
            this.txtb_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // comboBox_authors
            // 
            this.comboBox_authors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_authors.FormattingEnabled = true;
            this.comboBox_authors.Location = new System.Drawing.Point(96, 51);
            this.comboBox_authors.Name = "comboBox_authors";
            this.comboBox_authors.Size = new System.Drawing.Size(645, 24);
            this.comboBox_authors.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject:";
            // 
            // txtb_subject
            // 
            this.txtb_subject.Location = new System.Drawing.Point(96, 93);
            this.txtb_subject.Name = "txtb_subject";
            this.txtb_subject.Size = new System.Drawing.Size(645, 22);
            this.txtb_subject.TabIndex = 5;
            // 
            // txtb_message
            // 
            this.txtb_message.Location = new System.Drawing.Point(17, 133);
            this.txtb_message.Multiline = true;
            this.txtb_message.Name = "txtb_message";
            this.txtb_message.Size = new System.Drawing.Size(724, 268);
            this.txtb_message.TabIndex = 6;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_send.Location = new System.Drawing.Point(562, 407);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(179, 45);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(17, 407);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(129, 45);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SendEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 464);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtb_message);
            this.Controls.Add(this.txtb_subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_authors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendEmails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendEmails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_authors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_subject;
        private System.Windows.Forms.TextBox txtb_message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_back;
    }
}