
namespace ConferenceManagementSystem.src.main.view
{
    partial class PayRegistrationFee
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_cardnumber = new System.Windows.Forms.TextBox();
            this.txtb_cvv = new System.Windows.Forms.TextBox();
            this.txtb_cardholder = new System.Windows.Forms.TextBox();
            this.dtp_expDate = new System.Windows.Forms.DateTimePicker();
            this.back_button = new System.Windows.Forms.Button();
            this.pay_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(30, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Card Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(30, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CVV Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(30, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cardholder Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(30, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expiration Date:";
            // 
            // txtb_cardnumber
            // 
            this.txtb_cardnumber.Location = new System.Drawing.Point(197, 29);
            this.txtb_cardnumber.MaxLength = 16;
            this.txtb_cardnumber.Multiline = true;
            this.txtb_cardnumber.Name = "txtb_cardnumber";
            this.txtb_cardnumber.Size = new System.Drawing.Size(257, 30);
            this.txtb_cardnumber.TabIndex = 8;
            this.txtb_cardnumber.TextChanged += new System.EventHandler(this.txtb_cardnumber_TextChanged);
            // 
            // txtb_cvv
            // 
            this.txtb_cvv.Location = new System.Drawing.Point(197, 80);
            this.txtb_cvv.MaxLength = 3;
            this.txtb_cvv.Multiline = true;
            this.txtb_cvv.Name = "txtb_cvv";
            this.txtb_cvv.Size = new System.Drawing.Size(257, 30);
            this.txtb_cvv.TabIndex = 9;
            this.txtb_cvv.TextChanged += new System.EventHandler(this.txtb_cvv_TextChanged);
            // 
            // txtb_cardholder
            // 
            this.txtb_cardholder.Location = new System.Drawing.Point(197, 133);
            this.txtb_cardholder.MaxLength = 40;
            this.txtb_cardholder.Multiline = true;
            this.txtb_cardholder.Name = "txtb_cardholder";
            this.txtb_cardholder.Size = new System.Drawing.Size(257, 30);
            this.txtb_cardholder.TabIndex = 10;
            this.txtb_cardholder.TextChanged += new System.EventHandler(this.txtb_cardholder_TextChanged);
            // 
            // dtp_expDate
            // 
            this.dtp_expDate.Location = new System.Drawing.Point(197, 186);
            this.dtp_expDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtp_expDate.MinDate = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            this.dtp_expDate.Name = "dtp_expDate";
            this.dtp_expDate.Size = new System.Drawing.Size(257, 22);
            this.dtp_expDate.TabIndex = 11;
            this.dtp_expDate.Value = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(34, 244);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(125, 46);
            this.back_button.TabIndex = 12;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pay_button
            // 
            this.pay_button.Enabled = false;
            this.pay_button.Location = new System.Drawing.Point(296, 244);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(158, 46);
            this.pay_button.TabIndex = 13;
            this.pay_button.Text = "Pay Registration Fee";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Card Number must have 16 digits!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "CVV must have 3 digits!";
            // 
            // PayRegistrationFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dtp_expDate);
            this.Controls.Add(this.txtb_cardholder);
            this.Controls.Add(this.txtb_cvv);
            this.Controls.Add(this.txtb_cardnumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "PayRegistrationFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay the Registration Fee CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_cardnumber;
        private System.Windows.Forms.TextBox txtb_cvv;
        private System.Windows.Forms.TextBox txtb_cardholder;
        private System.Windows.Forms.DateTimePicker dtp_expDate;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}