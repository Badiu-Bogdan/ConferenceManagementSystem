using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class ReviewPaper : Form
    {
        AbstractPaperService abastractPaperService;
        PaperService paperService;
        ConferenceService conferenceService;
        User user;
        List<Paper> papers;
        List<Review> reviews;



        public ReviewPaper(AbstractPaperService abastractPaperService, PaperService paperService, ConferenceService conferenceService, User user)
        {
            this.abastractPaperService = abastractPaperService;
            this.paperService = paperService;
            this.conferenceService = conferenceService;
            this.user = user;
            InitializeComponent();

            this.displayPapers();
            this.displayPossibleReviews();

        }

        private void displayPapers()
        {
            papers = this.paperService.getPapersforReviewer(this.user.Id);
            papers.ForEach(paper =>
            {
                cmbox_papers.Items.Add(paper.getTitle());
            });
        }

        private void displayPossibleReviews()
        {
            reviews = this.abastractPaperService.getReviews();
            reviews.ForEach(review =>
            {
                cmbox_reviews.Items.Add(review.Verdict);
            });

        }



        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbox_reviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable the bid button
            if (cmbox_reviews.SelectedItem.ToString() != "not set yet")
                btn_Review_Paper.Enabled = true;
            else btn_Review_Paper.Enabled = false;
        }

        private void btn_Review_Paper_Click(object sender, EventArgs e)
        {
            try
            {
                this.paperService.updateReviewPaper(txtBox_comment.Text, reviews[cmbox_reviews.SelectedIndex].Id, papers[cmbox_papers.SelectedIndex].getTitle());

                papers.ForEach(paper =>
                {
                    if (cmbox_papers.SelectedItem == paper.getTitle())
                    {
                        this.paperService.changeAcceptance(paper.getIdAbstract());

                    }
                });
                

                MessageBox.Show("Added review to paper successfully!");
                QueryOtherReviews queryOtherReviews = new QueryOtherReviews(conferenceService, papers[cmbox_papers.SelectedIndex].getIdAbstract());
                queryOtherReviews.ShowDialog();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbox_papers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbox_abstractPaper.Text = this.abastractPaperService.getAbstractForId(papers[cmbox_papers.SelectedIndex].getIdAbstract()).Abstractpaper;
            btn_downloadPaper.Enabled = true;
            cmbox_reviews.Enabled = true;
        }

        private void btn_downloadPaper_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the location where to download the file";
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                try
                {
                    this.paperService.downloadPaper(folderBrowserDialog.SelectedPath, this.abastractPaperService.getAbstractForId(papers[cmbox_papers.SelectedIndex].getIdAbstract()).Id);
                    MessageBox.Show("Paper Downloaded Successfully.");
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
