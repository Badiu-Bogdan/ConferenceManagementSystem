using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class DecidePaperVerdict : Form
    {
        PaperService paperService;
        UserService userService;
        Conference selected_conference;
        List<Paper> papers;
        List<bool> papers_decided = new List<bool>();
        static bool ready = false;

        public DecidePaperVerdict(PaperService paperService, UserService userService, Conference selectedConference)
        {
            this.paperService = paperService;
            this.userService = userService;
            selected_conference = selectedConference;
            

            InitializeComponent();
            this.displayPapers();
        }

        private void displayPapers()
        {   
            if (ready == false)
            {
                papers = this.paperService.getPapersInContradictory();

                papers.ForEach(paper =>
                {
                    papers_decided.Add(false);
                    cmbox_papers.Items.Add(paper.getTitle());

                });
            }
                
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (cmbox_papers.Items.Count == 0)
                ready = true;
            this.DialogResult = DialogResult.OK;

        }

        private void cmbox_papers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            btn_new_eval.Enabled = true;
            btn_request_discussion.Enabled = true;
            btn_request_discussion.Enabled = true;
            accept_btn.Enabled = true;
            reject_btn.Enabled = true;
        }

        private void btn_request_discussion_Click(object sender, EventArgs e)
        {
            this.userService.createChat(cmbox_papers.SelectedItem.ToString());
            
            int i = 0;
            papers.ForEach(paper =>
            {
                if(cmbox_papers.SelectedItem == paper.getTitle())
                    papers_decided[i] = true;
                i++;
            });

            

            btn_new_eval.Enabled = false;
            btn_request_discussion.Enabled = false;
            accept_btn.Enabled = false;
            reject_btn.Enabled = false;


            cmbox_papers.Items.Clear();
            i = 0;
            papers.ForEach(paper =>
            {
                if (papers_decided[i] == false)
                    cmbox_papers.Items.Add(paper.getTitle());
               
                i++;
            });

            MessageBox.Show("Success! Reviewers are requested to discuss!");
        }

        private void btn_new_eval_Click(object sender, EventArgs e)
        {
            string paper_id = "";
            papers.ForEach(paper =>
            {
                if (cmbox_papers.SelectedItem == paper.getTitle())
                    paper_id = paper.getId();
            });


            int i = 0;
            papers.ForEach(paper =>
            {
                if (cmbox_papers.SelectedItem == paper.getTitle())
                    papers_decided[i] = true;
                i++;
            });

            btn_new_eval.Enabled = false;
            btn_request_discussion.Enabled = false;
            accept_btn.Enabled = false;
            reject_btn.Enabled = false;


            cmbox_papers.Items.Clear();
            i = 0;
            papers.ForEach(paper =>
            {
                if (papers_decided[i] == false)
                    cmbox_papers.Items.Add(paper.getTitle());
               
                i++;
            });

            this.userService.deleteReviewers(paper_id);

            ConferenceRepository<long, Conference> conferenceRepository = new ConferenceRepository<long, Conference>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            ConferenceService conferenceService = new ConferenceService(conferenceRepository);

            AbstractPaperRepository<long, AbstractPaper> abstractPaperRepository = new AbstractPaperRepository<long, AbstractPaper>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            AbstractPaperService abstractPaperService = new AbstractPaperService(abstractPaperRepository);

            ReviewRepository<long, ReviewerPaper> reviewRepository = new ReviewRepository<long, ReviewerPaper>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            ReviewerPaperService reviewerPaperService = new ReviewerPaperService(reviewRepository);

            this.Hide();
            AssignReviewersToPapers assignReviewersToPapers = new AssignReviewersToPapers(conferenceService, abstractPaperService, reviewerPaperService, selected_conference);
            assignReviewersToPapers.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            papers.ForEach(paper =>
            {
                if (cmbox_papers.SelectedItem == paper.getTitle())
                {
                    this.paperService.rejectProposal(paper.getIdAbstract());

                }
            });

            int i = 0;
            papers.ForEach(paper =>
            {
                if (cmbox_papers.SelectedItem == paper.getTitle())
                    papers_decided[i] = true;
                i++;
            });

            btn_new_eval.Enabled = false;
            btn_request_discussion.Enabled = false;
            accept_btn.Enabled = false;
            reject_btn.Enabled = false;

            cmbox_papers.Items.Clear();
            i = 0;
            papers.ForEach(paper =>
            {
                if (papers_decided[i] == false)
                    cmbox_papers.Items.Add(paper.getTitle());

                i++;
            });

            MessageBox.Show("Paper rejected successfully!");
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            papers.ForEach(paper =>
            {
                if (cmbox_papers.SelectedItem == paper.getTitle())
                {
                    this.paperService.acceptProposal(paper.getIdAbstract());

                }
            });

            int i = 0;
            papers.ForEach(paper =>
            {
                if (cmbox_papers.SelectedItem == paper.getTitle())
                    papers_decided[i] = true;
                i++;
            });

            btn_new_eval.Enabled = false;
            btn_request_discussion.Enabled = false;
            accept_btn.Enabled = false;
            reject_btn.Enabled = false;

            cmbox_papers.Items.Clear();
            i = 0;
            papers.ForEach(paper =>
            {
                if (papers_decided[i] == false)
                    cmbox_papers.Items.Add(paper.getTitle());

                i++;
            });

            MessageBox.Show("Paper accepted successfully!");
        }
    }
}
