
namespace ConferenceManagementSystem.src.main.view
{
    partial class QueryOtherReviews
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
            this.lstbx_reviews = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(12, 319);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(99, 43);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lstbx_reviews
            // 
            this.lstbx_reviews.FormattingEnabled = true;
            this.lstbx_reviews.ItemHeight = 16;
            this.lstbx_reviews.Location = new System.Drawing.Point(12, 12);
            this.lstbx_reviews.Name = "lstbx_reviews";
            this.lstbx_reviews.Size = new System.Drawing.Size(400, 292);
            this.lstbx_reviews.TabIndex = 2;
            // 
            // QueryOtherReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 374);
            this.Controls.Add(this.lstbx_reviews);
            this.Controls.Add(this.btn_back);
            this.Name = "QueryOtherReviews";
            this.Text = "QueryOtherReviews";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox lstbx_reviews;
    }
}