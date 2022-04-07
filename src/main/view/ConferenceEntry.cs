using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class ConferenceEntry : Form
    {
        ConferenceService conferenceService;
        PaperService paperService;
        PresentationService presentationService;
        AbstractPaperService abstractPaperService;
        User user;
        Conference conference;
        AbstractPaper selectedAbstract;

        public ConferenceEntry(User user, Conference conference, ConferenceService conferenceService, PaperService paperService, PresentationService presentationService, AbstractPaperService abstractPaperService)
        {
            this.user = user;
            this.conference = conference;
            this.conferenceService = conferenceService;
            this.paperService = paperService;
            this.presentationService = presentationService;
            this.abstractPaperService = abstractPaperService;
            InitializeComponent();

            // load papers
            this.displayPapersList();
        }

        private void displayPapersList()
        {
            List<AbstractPaper> papers = this.abstractPaperService.getAbstractsForAuthor(user.Id);
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

        private void btn_downloadPaper_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the location where to download the file";
            DialogResult result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                try
                {
                    this.paperService.downloadPaper(folderBrowserDialog.SelectedPath, selectedAbstract.Id);
                    MessageBox.Show("Paper Downloaded Successfully.");
                }
                catch(ServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void cmbox_papers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbox_papers.SelectedIndex >= 0)
            {
                // check if the selected proposal has a paper associated
                List<AbstractPaper> papers = this.abstractPaperService.getAbstractsForAuthor(user.Id);
                this.selectedAbstract = papers[cmbox_papers.SelectedIndex];
                txtbox_keywords.Text = this.selectedAbstract.Keywords;
                txtbox_metainfo.Text = this.selectedAbstract.Metainfo;
                txtbox_abstractPaper.Text = this.selectedAbstract.Abstractpaper;
                txtbox_authors.Text = this.abstractPaperService.getAuthorsForAbstract(this.selectedAbstract.Id);
                lbl_isAccepted.Visible = true;
                if (this.selectedAbstract.IsAccepted == "1")
                {
                    lbl_isAccepted.Text = "*Accepted";
                }
                else if(this.selectedAbstract.IsAccepted == "0")
                {
                    lbl_isAccepted.Text = "*Not accepted";
                }
                else
                {
                    lbl_isAccepted.Text = "*Not yet accepted";
                }


                txtbox_topics.Text = this.abstractPaperService.getTopicsForAnAbstract(this.selectedAbstract.Id);
                if (this.abstractPaperService.abstractHasPaper(this.selectedAbstract.Id))
                {
                    btn_downloadPaper.Enabled = true;
                    btn_download_pres.Enabled = true;
                    lbl_noPaperForProposal.Visible = false;
                }
                else
                {
                    btn_downloadPaper.Enabled = false;
                    btn_download_pres.Enabled = false;
                    lbl_noPaperForProposal.Visible = true;
                }
            }
        }

        private void btn_download_pres_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the location where to download the presentation";
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                try
                {
                    this.presentationService.downloadPresentation(folderBrowserDialog.SelectedPath, selectedAbstract.Id);
                    MessageBox.Show("Presentation Downloaded Successfully.");
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
