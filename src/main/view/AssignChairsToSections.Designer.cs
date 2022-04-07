
namespace ConferenceManagementSystem.src.main.view
{
    partial class AssignChairsToSections
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
            this.cmbx_sections = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listbx_chairs = new System.Windows.Forms.ListBox();
            this.btn_assign = new System.Windows.Forms.Button();
            this.lbl_assigned = new System.Windows.Forms.Label();
            this.btn_unassign = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_back.Location = new System.Drawing.Point(13, 448);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Section";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbx_sections
            // 
            this.cmbx_sections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_sections.FormattingEnabled = true;
            this.cmbx_sections.Location = new System.Drawing.Point(85, 339);
            this.cmbx_sections.Name = "cmbx_sections";
            this.cmbx_sections.Size = new System.Drawing.Size(283, 24);
            this.cmbx_sections.TabIndex = 22;
            this.cmbx_sections.SelectedIndexChanged += new System.EventHandler(this.cmbx_sections_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Chairs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listbx_chairs
            // 
            this.listbx_chairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listbx_chairs.FormattingEnabled = true;
            this.listbx_chairs.ItemHeight = 20;
            this.listbx_chairs.Location = new System.Drawing.Point(17, 35);
            this.listbx_chairs.Name = "listbx_chairs";
            this.listbx_chairs.Size = new System.Drawing.Size(523, 284);
            this.listbx_chairs.TabIndex = 24;
            this.listbx_chairs.SelectedIndexChanged += new System.EventHandler(this.listbx_chairs_SelectedIndexChanged);
            // 
            // btn_assign
            // 
            this.btn_assign.Enabled = false;
            this.btn_assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_assign.Location = new System.Drawing.Point(413, 334);
            this.btn_assign.Margin = new System.Windows.Forms.Padding(4);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(126, 41);
            this.btn_assign.TabIndex = 33;
            this.btn_assign.Text = "Assign";
            this.btn_assign.UseVisualStyleBackColor = true;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // lbl_assigned
            // 
            this.lbl_assigned.AutoSize = true;
            this.lbl_assigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_assigned.Location = new System.Drawing.Point(13, 383);
            this.lbl_assigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_assigned.Name = "lbl_assigned";
            this.lbl_assigned.Size = new System.Drawing.Size(94, 20);
            this.lbl_assigned.TabIndex = 34;
            this.lbl_assigned.Text = "Assigned: -";
            this.lbl_assigned.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_unassign
            // 
            this.btn_unassign.Enabled = false;
            this.btn_unassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_unassign.Location = new System.Drawing.Point(413, 383);
            this.btn_unassign.Margin = new System.Windows.Forms.Padding(4);
            this.btn_unassign.Name = "btn_unassign";
            this.btn_unassign.Size = new System.Drawing.Size(126, 41);
            this.btn_unassign.TabIndex = 35;
            this.btn_unassign.Text = "Unassign";
            this.btn_unassign.UseVisualStyleBackColor = true;
            this.btn_unassign.Click += new System.EventHandler(this.btn_unassign_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_save.Location = new System.Drawing.Point(454, 445);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 41);
            this.btn_save.TabIndex = 36;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AssignChairsToSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 499);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_unassign);
            this.Controls.Add(this.lbl_assigned);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.listbx_chairs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_sections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Name = "AssignChairsToSections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Chairs To Sections CMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_sections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbx_chairs;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Label lbl_assigned;
        private System.Windows.Forms.Button btn_unassign;
        private System.Windows.Forms.Button btn_save;
    }
}