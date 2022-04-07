
namespace ConferenceManagementSystem.src.main.view
{
    partial class bidProposal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_proposals = new System.Windows.Forms.ComboBox();
            this.txtb_abstract = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_bid = new System.Windows.Forms.Button();
            this.cmbox_verdicts = new System.Windows.Forms.ComboBox();
            this.lbl_alreadyBid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(17, 424);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 41);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Proposal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(23, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Verdict:";
            // 
            // cmbox_proposals
            // 
            this.cmbox_proposals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_proposals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbox_proposals.FormattingEnabled = true;
            this.cmbox_proposals.Location = new System.Drawing.Point(118, 9);
            this.cmbox_proposals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbox_proposals.Name = "cmbox_proposals";
            this.cmbox_proposals.Size = new System.Drawing.Size(634, 26);
            this.cmbox_proposals.TabIndex = 24;
            this.cmbox_proposals.SelectedIndexChanged += new System.EventHandler(this.cmbox_proposals_SelectedIndexChanged);
            // 
            // txtb_abstract
            // 
            this.txtb_abstract.Enabled = false;
            this.txtb_abstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtb_abstract.Location = new System.Drawing.Point(17, 73);
            this.txtb_abstract.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_abstract.Multiline = true;
            this.txtb_abstract.Name = "txtb_abstract";
            this.txtb_abstract.Size = new System.Drawing.Size(735, 297);
            this.txtb_abstract.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Abstract:";
            // 
            // btn_bid
            // 
            this.btn_bid.Enabled = false;
            this.btn_bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_bid.Location = new System.Drawing.Point(649, 424);
            this.btn_bid.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bid.Name = "btn_bid";
            this.btn_bid.Size = new System.Drawing.Size(103, 41);
            this.btn_bid.TabIndex = 11;
            this.btn_bid.Text = "Bid";
            this.btn_bid.UseVisualStyleBackColor = true;
            this.btn_bid.Click += new System.EventHandler(this.btn_bid_Click);
            // 
            // cmbox_verdicts
            // 
            this.cmbox_verdicts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_verdicts.Enabled = false;
            this.cmbox_verdicts.FormattingEnabled = true;
            this.cmbox_verdicts.Location = new System.Drawing.Point(128, 383);
            this.cmbox_verdicts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbox_verdicts.Name = "cmbox_verdicts";
            this.cmbox_verdicts.Size = new System.Drawing.Size(206, 24);
            this.cmbox_verdicts.TabIndex = 24;
            this.cmbox_verdicts.SelectedIndexChanged += new System.EventHandler(this.cmbox_verdicts_SelectedIndexChanged);
            // 
            // lbl_alreadyBid
            // 
            this.lbl_alreadyBid.AutoSize = true;
            this.lbl_alreadyBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_alreadyBid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_alreadyBid.Location = new System.Drawing.Point(114, 40);
            this.lbl_alreadyBid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_alreadyBid.Name = "lbl_alreadyBid";
            this.lbl_alreadyBid.Size = new System.Drawing.Size(267, 20);
            this.lbl_alreadyBid.TabIndex = 12;
            this.lbl_alreadyBid.Text = "You have already bid for this paper";
            this.lbl_alreadyBid.Visible = false;
            // 
            // bidProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 478);
            this.Controls.Add(this.txtb_abstract);
            this.Controls.Add(this.cmbox_verdicts);
            this.Controls.Add(this.cmbox_proposals);
            this.Controls.Add(this.lbl_alreadyBid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_bid);
            this.Controls.Add(this.btn_back);
            this.Name = "bidProposal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bid Proposal CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_proposals;
        private System.Windows.Forms.TextBox txtb_abstract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_bid;
        private System.Windows.Forms.ComboBox cmbox_verdicts;
        private System.Windows.Forms.Label lbl_alreadyBid;
    }
}