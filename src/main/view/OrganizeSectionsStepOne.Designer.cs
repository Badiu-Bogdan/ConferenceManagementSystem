
namespace ConferenceManagementSystem.src.main.view
{
    partial class OrganizeSectionsStepOne
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
            this.label1 = new System.Windows.Forms.Label();
            this.listbx_accepted = new System.Windows.Forms.ListBox();
            this.lbl_paper = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_eligibleSections = new System.Windows.Forms.ComboBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listbx_selected = new System.Windows.Forms.ListBox();
            this.cmbx_selectedSections = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sendToSection = new System.Windows.Forms.Button();
            this.btn_removeFromSection = new System.Windows.Forms.Button();
            this.txtb_abstract = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_noPapers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(13, 480);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Accepted Papers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listbx_accepted
            // 
            this.listbx_accepted.FormattingEnabled = true;
            this.listbx_accepted.ItemHeight = 16;
            this.listbx_accepted.Location = new System.Drawing.Point(13, 46);
            this.listbx_accepted.Name = "listbx_accepted";
            this.listbx_accepted.Size = new System.Drawing.Size(287, 420);
            this.listbx_accepted.TabIndex = 12;
            this.listbx_accepted.SelectedIndexChanged += new System.EventHandler(this.listbx_accepted_SelectedIndexChanged);
            // 
            // lbl_paper
            // 
            this.lbl_paper.AutoSize = true;
            this.lbl_paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_paper.Location = new System.Drawing.Point(315, 46);
            this.lbl_paper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_paper.Name = "lbl_paper";
            this.lbl_paper.Size = new System.Drawing.Size(131, 20);
            this.lbl_paper.TabIndex = 13;
            this.lbl_paper.Text = "Eligible sections";
            this.lbl_paper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(740, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sections";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbx_eligibleSections
            // 
            this.cmbx_eligibleSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_eligibleSections.Enabled = false;
            this.cmbx_eligibleSections.FormattingEnabled = true;
            this.cmbx_eligibleSections.Location = new System.Drawing.Point(319, 69);
            this.cmbx_eligibleSections.Name = "cmbx_eligibleSections";
            this.cmbx_eligibleSections.Size = new System.Drawing.Size(196, 24);
            this.cmbx_eligibleSections.TabIndex = 15;
            this.cmbx_eligibleSections.SelectedIndexChanged += new System.EventHandler(this.cmbx_eligibleSections_SelectedIndexChanged);
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_next.Location = new System.Drawing.Point(954, 480);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(101, 41);
            this.btn_next.TabIndex = 16;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(106, 490);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Step 1/3: Add each accepted paper to a section";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listbx_selected
            // 
            this.listbx_selected.FormattingEnabled = true;
            this.listbx_selected.ItemHeight = 16;
            this.listbx_selected.Location = new System.Drawing.Point(744, 63);
            this.listbx_selected.Name = "listbx_selected";
            this.listbx_selected.Size = new System.Drawing.Size(311, 404);
            this.listbx_selected.TabIndex = 18;
            this.listbx_selected.SelectedIndexChanged += new System.EventHandler(this.listbx_selected_SelectedIndexChanged);
            // 
            // cmbx_selectedSections
            // 
            this.cmbx_selectedSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_selectedSections.FormattingEnabled = true;
            this.cmbx_selectedSections.Location = new System.Drawing.Point(822, 10);
            this.cmbx_selectedSections.Name = "cmbx_selectedSections";
            this.cmbx_selectedSections.Size = new System.Drawing.Size(233, 24);
            this.cmbx_selectedSections.TabIndex = 19;
            this.cmbx_selectedSections.SelectedIndexChanged += new System.EventHandler(this.cmbx_selectedSections_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(740, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Selected papers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_sendToSection
            // 
            this.btn_sendToSection.Enabled = false;
            this.btn_sendToSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_sendToSection.Location = new System.Drawing.Point(527, 62);
            this.btn_sendToSection.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendToSection.Name = "btn_sendToSection";
            this.btn_sendToSection.Size = new System.Drawing.Size(196, 41);
            this.btn_sendToSection.TabIndex = 21;
            this.btn_sendToSection.Text = "Send to section";
            this.btn_sendToSection.UseVisualStyleBackColor = true;
            this.btn_sendToSection.Click += new System.EventHandler(this.btn_sendToSection_Click);
            // 
            // btn_removeFromSection
            // 
            this.btn_removeFromSection.Enabled = false;
            this.btn_removeFromSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_removeFromSection.Location = new System.Drawing.Point(490, 425);
            this.btn_removeFromSection.Margin = new System.Windows.Forms.Padding(4);
            this.btn_removeFromSection.Name = "btn_removeFromSection";
            this.btn_removeFromSection.Size = new System.Drawing.Size(233, 41);
            this.btn_removeFromSection.TabIndex = 22;
            this.btn_removeFromSection.Text = "Remove from section";
            this.btn_removeFromSection.UseVisualStyleBackColor = true;
            this.btn_removeFromSection.Click += new System.EventHandler(this.btn_removeFromSection_Click);
            // 
            // txtb_abstract
            // 
            this.txtb_abstract.BackColor = System.Drawing.SystemColors.Menu;
            this.txtb_abstract.Enabled = false;
            this.txtb_abstract.Location = new System.Drawing.Point(319, 126);
            this.txtb_abstract.Multiline = true;
            this.txtb_abstract.Name = "txtb_abstract";
            this.txtb_abstract.Size = new System.Drawing.Size(404, 292);
            this.txtb_abstract.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(315, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Abstract";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_noPapers
            // 
            this.lbl_noPapers.AutoSize = true;
            this.lbl_noPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_noPapers.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_noPapers.Location = new System.Drawing.Point(896, 40);
            this.lbl_noPapers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_noPapers.Name = "lbl_noPapers";
            this.lbl_noPapers.Size = new System.Drawing.Size(135, 20);
            this.lbl_noPapers.TabIndex = 25;
            this.lbl_noPapers.Text = "*Nothing to show";
            this.lbl_noPapers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_noPapers.Visible = false;
            // 
            // OrganizeSectionsStepOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 534);
            this.Controls.Add(this.lbl_noPapers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_abstract);
            this.Controls.Add(this.btn_removeFromSection);
            this.Controls.Add(this.btn_sendToSection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbx_selectedSections);
            this.Controls.Add(this.listbx_selected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.cmbx_eligibleSections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_paper);
            this.Controls.Add(this.listbx_accepted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Name = "OrganizeSectionsStepOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organize Sections 1/3 CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbx_accepted;
        private System.Windows.Forms.Label lbl_paper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_eligibleSections;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbx_selected;
        private System.Windows.Forms.ComboBox cmbx_selectedSections;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sendToSection;
        private System.Windows.Forms.Button btn_removeFromSection;
        private System.Windows.Forms.TextBox txtb_abstract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_noPapers;
    }
}