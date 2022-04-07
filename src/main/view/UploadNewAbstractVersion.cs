using System;
using System.Collections.Generic;
using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class UploadNewAbstractVersion : Form
    {
        AbstractPaperService paperService;
        User user;

        public UploadNewAbstractVersion(AbstractPaperService paperService, User user)
        {
            this.paperService = paperService;
            this.user = user;
            InitializeComponent();
            this.loadPapersCombobox();
        }

        private void loadPapersCombobox()
        {
            List<AbstractPaper> papers = paperService.getAbstractsForAuthor(user.Id);
            papers.ForEach(paper =>
            {
                cmbox_papers.Items.Add(paper.Name);
            });
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }



        private void btn_uploadNewPaperVersion_Click(object sender, EventArgs e)
        {
            try
            {
                string title = cmbox_papers.SelectedItem.ToString();
                string newAbstract = txtb_abstractPaper.Text;
                this.paperService.uploadNewPaperVersion(title, newAbstract);
                MessageBox.Show("Abstract Paper version uploaded successfully!");
                goToPreviousForm();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbox_papers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_papers.SelectedIndex >= 0)
            {
                btn_uploadNewPaperVersion.Enabled = true;
            }
        }
    }
}
