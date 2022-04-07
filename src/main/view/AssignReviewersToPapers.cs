using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConferenceManagementSystem.src.main.service;
using ConferenceManagementSystem.src.main.domain;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class AssignReviewersToPapers : Form
    {
        AbstractPaperService abstractPaperService;
        ConferenceService conferenceService;
        ReviewerPaperService reviewerPaperService;
        int selectedConferenceId;
        string paper_id;

        public AssignReviewersToPapers(ConferenceService new_conferenceService, AbstractPaperService new_abstractPaperService, ReviewerPaperService reviewerPaperService, String selected_conference)
        {
            this.conferenceService = new_conferenceService;
            this.abstractPaperService = new_abstractPaperService;
            this.reviewerPaperService = reviewerPaperService;
            InitializeComponent();

            if (selected_conference == "")
            {
                this.lbl_conference.Text = "Please select a conference!";
                selectedConferenceId = -1;
            }
            else
            {
                this.lbl_conference.Text = "Connected at conference: " + selected_conference;
                selectedConferenceId = Int32.Parse(selected_conference.Split(new string[] { ". " }, StringSplitOptions.None)[0]);
            }

            this.displayConferenceList();
        }

        public AssignReviewersToPapers(ConferenceService new_conferenceService, AbstractPaperService new_abstractPaperService, ReviewerPaperService reviewerPaperService, Conference selected_conference)
        {
            this.conferenceService = new_conferenceService;
            this.abstractPaperService = new_abstractPaperService;
            this.reviewerPaperService = reviewerPaperService;
            InitializeComponent();

            if (selected_conference == null)
            {
                this.lbl_conference.Text = "Please select a conference!";
                selectedConferenceId = -1;
            }
            else
            {
                this.lbl_conference.Text = "Connected at conference: " + selected_conference;
                selectedConferenceId = selected_conference.getId();
            }

            this.displayConferenceList();
        }

        private void displayConferenceList()
        {
            List<Conference> conferences = conferenceService.getConferences();
            conferences.ForEach(conf =>
            {
                cmbox_conferences.Items.Add(conf.getId().ToString() + ". " + conf.getTitle());
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


        /*
         * Load button function. For "Load Papers" button.
         * This function takes all abstract papers from the repository 
         * all elements that match the conference id with the current selected 
         * conference.Something like select from coferences where id = curentId.
         * All confereces are loaded in the left DataGridView(dataGridViewPapers).
         */
        private void btn_load_papers_Click(object sender, EventArgs e)
        {
            //If no conference is selected throw MessageBox
            if (selectedConferenceId == -1)
            {
                MessageBox.Show("You need to select a conference!");
                return;
            }

            //Refresh datagridview so when you load another conference elements will not be concatenated with the 
            //previous ones
            dataGridViewPapers.Rows.Clear();
            dataGridViewPapers.Refresh();
            try
            {
                foreach(AbstractPaper abstractPaper in this.abstractPaperService.getAbstractsForConference(selectedConferenceId))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewPapers);
                    row.Cells[0].Value = abstractPaper.Id;
                    row.Cells[1].Value = abstractPaper.Name;

                    dataGridViewPapers.Rows.Add(row);
                }
            }
            catch (ServiceException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_load_reviewers_Click(object sender, EventArgs e)
        {
            //Check if one paper is selected in datagridviewPapers.
            int count = 0;
            foreach(DataGridViewRow row in dataGridViewPapers.Rows)
                if (Convert.ToBoolean(row.Cells[2].Value))
                    count++;
            

            if(count != 1)
            {
                MessageBox.Show("You cannot load more than 1 paper!");
                return;
            }

            //take the id of the selected paper
            foreach (DataGridViewRow row in dataGridViewPapers.Rows)
                if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    paper_id = row.Cells[0].Value.ToString();
                }

            dataGridViewReviewers.Rows.Clear();
            dataGridViewReviewers.Refresh();
            try
            {
                foreach (BidProposal bidProposal in this.abstractPaperService.getBidProposalsForPaper(paper_id))
                {
                    if(bidProposal.getIdVerdict() == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewReviewers);
                        row.Cells[0].Value = bidProposal.getId();
                        row.Cells[1].Value = bidProposal.getIdReviewer();
                        row.Cells[2].Value = false;
                        row.Cells[2].ReadOnly = true;
                        dataGridViewReviewers.Rows.Add(row);
                    }
                    else
                    {
                        
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewReviewers);
                        row.Cells[0].Value = bidProposal.getId();
                        row.Cells[1].Value = bidProposal.getIdReviewer();
                        if(this.reviewerPaperService.CheckIfReviewAllreadyAssigned(bidProposal.getId()) == true)
                        {
                            row.Cells[2].Value = true;
                            row.Cells[2].ReadOnly = true;
                        }
                        else
                        {
                            row.Cells[2].Value = false;
                        }

                        dataGridViewReviewers.Rows.Add(row);
                    }
                }
            }
            catch (ServiceException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_save_reviewers_Click(object sender, EventArgs e)
        {
            if (dataGridViewReviewers.Rows.Count == 0)
                MessageBox.Show("you need to select a reviewer!");

            foreach(DataGridViewRow row in dataGridViewReviewers.Rows)
            {
                if(Convert.ToBoolean(row.Cells[2].Value) == true && row.Cells[2].ReadOnly == false)
                {
                    string comment = "default comment";
                    ReviewerPaper new_review = new ReviewerPaper(0, comment, DateTime.Now, Convert.ToInt32(row.Cells[0].Value), 1);
                    try
                    {
                        this.reviewerPaperService.addReviewer(new_review);
                    }
                    catch(ServiceException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        private void cmbox_conferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_conferences.SelectedIndex >= 0)
            {
                string conferenceTitle = cmbox_conferences.SelectedItem.ToString();
                selectedConferenceId = Int32.Parse(conferenceTitle.Split(new string[] { ". " }, StringSplitOptions.None)[0]);
                dataGridViewReviewers.Rows.Clear();
                dataGridViewReviewers.Refresh();
                dataGridViewPapers.Rows.Clear();
                dataGridViewPapers.Refresh();
            }
        }
    }
}
