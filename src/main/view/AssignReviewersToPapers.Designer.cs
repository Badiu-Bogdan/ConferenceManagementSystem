
namespace ConferenceManagementSystem.src.main.view
{
    partial class AssignReviewersToPapers
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
            this.cmbox_conferences = new System.Windows.Forms.ComboBox();
            this.lbl_conference = new System.Windows.Forms.Label();
            this.dataGridViewReviewers = new System.Windows.Forms.DataGridView();
            this.IdBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_reviewer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_box_reviewer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_load_reviewers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save_reviewers = new System.Windows.Forms.Button();
            this.btn_load_papers = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridViewPapers = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewersCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviewers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPapers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(791, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Conference:";
            // 
            // cmbox_conferences
            // 
            this.cmbox_conferences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_conferences.FormattingEnabled = true;
            this.cmbox_conferences.Location = new System.Drawing.Point(795, 43);
            this.cmbox_conferences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbox_conferences.Name = "cmbox_conferences";
            this.cmbox_conferences.Size = new System.Drawing.Size(233, 24);
            this.cmbox_conferences.TabIndex = 11;
            this.cmbox_conferences.SelectedIndexChanged += new System.EventHandler(this.cmbox_conferences_SelectedIndexChanged);
            // 
            // lbl_conference
            // 
            this.lbl_conference.AutoSize = true;
            this.lbl_conference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conference.Location = new System.Drawing.Point(15, 11);
            this.lbl_conference.Name = "lbl_conference";
            this.lbl_conference.Size = new System.Drawing.Size(346, 20);
            this.lbl_conference.TabIndex = 12;
            this.lbl_conference.Text = "Connected at conference: <conference>";
            this.lbl_conference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewReviewers
            // 
            this.dataGridViewReviewers.AllowUserToAddRows = false;
            this.dataGridViewReviewers.AllowUserToDeleteRows = false;
            this.dataGridViewReviewers.AllowUserToOrderColumns = true;
            this.dataGridViewReviewers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviewers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBid,
            this.id_reviewer,
            this.check_box_reviewer});
            this.dataGridViewReviewers.Location = new System.Drawing.Point(545, 90);
            this.dataGridViewReviewers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewReviewers.Name = "dataGridViewReviewers";
            this.dataGridViewReviewers.RowHeadersWidth = 51;
            this.dataGridViewReviewers.Size = new System.Drawing.Size(517, 302);
            this.dataGridViewReviewers.TabIndex = 14;
            // 
            // IdBid
            // 
            this.IdBid.HeaderText = "IdBid";
            this.IdBid.MinimumWidth = 6;
            this.IdBid.Name = "IdBid";
            this.IdBid.ReadOnly = true;
            this.IdBid.Width = 125;
            // 
            // id_reviewer
            // 
            this.id_reviewer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_reviewer.HeaderText = "IdReviewer";
            this.id_reviewer.MinimumWidth = 6;
            this.id_reviewer.Name = "id_reviewer";
            this.id_reviewer.ReadOnly = true;
            // 
            // check_box_reviewer
            // 
            this.check_box_reviewer.HeaderText = "SelectReviewer";
            this.check_box_reviewer.MinimumWidth = 6;
            this.check_box_reviewer.Name = "check_box_reviewer";
            this.check_box_reviewer.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(16, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select a paper from the list above";
            // 
            // btn_load_reviewers
            // 
            this.btn_load_reviewers.Location = new System.Drawing.Point(16, 448);
            this.btn_load_reviewers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_load_reviewers.Name = "btn_load_reviewers";
            this.btn_load_reviewers.Size = new System.Drawing.Size(187, 28);
            this.btn_load_reviewers.TabIndex = 16;
            this.btn_load_reviewers.Text = "Load Reviewers";
            this.btn_load_reviewers.UseVisualStyleBackColor = true;
            this.btn_load_reviewers.Click += new System.EventHandler(this.btn_load_reviewers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(787, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select reviewers from the list above";
            // 
            // btn_save_reviewers
            // 
            this.btn_save_reviewers.Location = new System.Drawing.Point(864, 448);
            this.btn_save_reviewers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save_reviewers.Name = "btn_save_reviewers";
            this.btn_save_reviewers.Size = new System.Drawing.Size(187, 28);
            this.btn_save_reviewers.TabIndex = 18;
            this.btn_save_reviewers.Text = "Save Reviewers";
            this.btn_save_reviewers.UseVisualStyleBackColor = true;
            this.btn_save_reviewers.Click += new System.EventHandler(this.btn_save_reviewers_Click);
            // 
            // btn_load_papers
            // 
            this.btn_load_papers.Location = new System.Drawing.Point(335, 47);
            this.btn_load_papers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_load_papers.Name = "btn_load_papers";
            this.btn_load_papers.Size = new System.Drawing.Size(187, 28);
            this.btn_load_papers.TabIndex = 19;
            this.btn_load_papers.Text = "Load Papers";
            this.btn_load_papers.UseVisualStyleBackColor = true;
            this.btn_load_papers.Click += new System.EventHandler(this.btn_load_papers_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(545, 47);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(187, 28);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridViewPapers
            // 
            this.dataGridViewPapers.AllowUserToAddRows = false;
            this.dataGridViewPapers.AllowUserToDeleteRows = false;
            this.dataGridViewPapers.AllowUserToOrderColumns = true;
            this.dataGridViewPapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPapers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.reviewersCheckBox});
            this.dataGridViewPapers.Location = new System.Drawing.Point(4, 90);
            this.dataGridViewPapers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPapers.Name = "dataGridViewPapers";
            this.dataGridViewPapers.RowHeadersWidth = 51;
            this.dataGridViewPapers.Size = new System.Drawing.Size(517, 302);
            this.dataGridViewPapers.TabIndex = 13;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.Width = 41;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // reviewersCheckBox
            // 
            this.reviewersCheckBox.HeaderText = "SeeReviewers";
            this.reviewersCheckBox.MinimumWidth = 6;
            this.reviewersCheckBox.Name = "reviewersCheckBox";
            this.reviewersCheckBox.Width = 125;
            // 
            // AssignReviewersToPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_load_papers);
            this.Controls.Add(this.btn_save_reviewers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_load_reviewers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewReviewers);
            this.Controls.Add(this.dataGridViewPapers);
            this.Controls.Add(this.lbl_conference);
            this.Controls.Add(this.cmbox_conferences);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssignReviewersToPapers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Reviewers To Papers CMS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviewers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPapers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_conferences;
        private System.Windows.Forms.Label lbl_conference;
        private System.Windows.Forms.DataGridView dataGridViewReviewers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_load_reviewers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save_reviewers;
        private System.Windows.Forms.Button btn_load_papers;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridViewPapers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reviewersCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reviewer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_box_reviewer;
    }
}