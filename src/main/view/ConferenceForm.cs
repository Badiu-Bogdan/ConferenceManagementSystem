using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class ConferenceForm : Form
    {

        UserService userService;
        ConferenceService conferenceService;
        PaperService paperService;
        AbstractPaperService abstractPaperService;
        PresentationService presentationService;
        EmailService emailService;
        User loggedUser;
        Conference currentConference;

        public ConferenceForm(UserService userService, ConferenceService conferenceService, AbstractPaperService abstractPaperService, PaperService paperService, EmailService emailService, PresentationService presentationService, User user, Conference conference)
        {
            this.userService = userService;
            this.conferenceService = conferenceService;
            this.paperService = paperService;
            this.abstractPaperService = abstractPaperService;
            this.emailService = emailService;
            this.presentationService = presentationService;
            this.loggedUser = user;
            this.currentConference = conference;

            InitializeComponent();

            checkChat();
            displayConferenceData();
            disableButtons();
            checkCurrentPhase();
        }

        // refresh the current conference
        private void refreshConference()
        {
            this.currentConference = conferenceService.getConferenceForId(currentConference.getId());
        }

        //check if the user is requested to discuss
        private void checkChat()
        {
            if (userService.isRequestedToDiscuss(this.loggedUser))
                btn_chat.Enabled = true;
        }

        // displays conference related data in disabled textboxes
        public void displayConferenceData()
        {
            refreshConference();
            User organizer = this.userService.getUser(this.currentConference.getOrganizerId());
            txtb_confTitle.Text = this.currentConference.getTitle();
            txtb_confDesc.Text = this.currentConference.getDescription();
            dtp_confStartDate.Text = this.currentConference.getStartDate().ToString();
            dtp_confEndDate.Text = this.currentConference.getEndDate().ToString();
            dtp_confStartCFP.Text = this.currentConference.getStartCFP().ToString();
            dtp_confEndCFPProp.Text = this.currentConference.getEndCFPProp().ToString();
            dtp_confEndCFPPaper.Text = this.currentConference.getEndCFPPaper().ToString();
            txtb_organizer.Text = organizer.FirstName + " " + organizer.LastName;
            if (!this.currentConference.getRequiresPaper()) {
                lbl_requirePaper.Text = "Does not require papers";
            }
        }

        //check if the user has the permissions to postpone the deadline
        private bool checkPermissionPostponeDeadline()
        {
            //check if the user is a chair
            List<UserType> typesOfTheUser = this.userService.getUserTypesForUser(this.loggedUser);

            //2 is the id for the Chair in the db table (TypeOfUsers) and 10 is for the Admin
            return typesOfTheUser.Any(u => u.getId() == 2 || u.getId() == 10);

        }

        //disable buttons based on the dates of the current conference
        private void disableButtons()
        {
            // disable the "upload full paper" and "upload new paper version" in case the CFP period is over
            if(DateTime.Compare(this.currentConference.getEndCFPPaper(), DateTime.Now) < 0)
            {
                btn_uploadFullPaper.Enabled = false;
                btn_uploadNewPaperVersion.Enabled = false;
            }

            // disable the "upload abstract paper" and "upload new abstract paper version" in case the CFP period is over
            if (DateTime.Compare(this.currentConference.getEndCFPProp(), DateTime.Now) < 0)
            {
                btn_uploadAbstractPaper.Enabled = false;
                btn_uploadNewVersionAbstractPaper.Enabled = false;
            }

            // disable the postpone deadline button in case the user does not have the proper permissions
            if (checkPermissionPostponeDeadline() == false)
            {
                btn_postponeConfDead.Visible = false;
            }

            // disable the bid proposal button in case the CFP (for proposal) is not over yet or the conference has started
            if (DateTime.Compare(this.currentConference.getEndCFPProp(), DateTime.Now) > 0 ||
                DateTime.Compare(this.currentConference.getStartDate(), DateTime.Now) < 0)
            {
                btn_bidProposal.Enabled = false;
            }

            // enable the postpone conference button in case the CFP is not over yet
            if (DateTime.Compare(this.currentConference.getEndCFPProp(), DateTime.Now) > 0 ||
                DateTime.Compare(this.currentConference.getEndCFPPaper(), DateTime.Now) > 0)
            {
                btn_postponeConfDead.Enabled = true;
            }
            else
            {
                btn_postponeConfDead.Enabled = false;
            }

            // display the lbl_cfpOver label in case the CFP period is over
            if (DateTime.Compare(this.currentConference.getEndCFPProp(), DateTime.Now) < 0 ||
                DateTime.Compare(this.currentConference.getEndCFPPaper(), DateTime.Now) < 0)
            {
                lbl_cfpOver.Visible = true;
            }

            // enable the lbl_confStarted button in case the conference is in progress
            if (DateTime.Compare(this.currentConference.getStartDate(), DateTime.Now) < 0 &&
                DateTime.Compare(this.currentConference.getEndDate(), DateTime.Now) > 0)
            {
                lbl_confInProgress.Visible = true;
            }

            // disable decide paper verdict, review paper and joinSession if the conference has started
            if (DateTime.Compare(this.currentConference.getStartDate(), DateTime.Now) < 0)
            {
                btn_decide_verdict.Enabled = false;
                btn_Review_Paper.Enabled = false;
                btn_joinSession.Enabled = false;
            }

            // enable organize sections and assign chairs to sections if date between the end of CFP and start of conference
            if (DateTime.Compare(this.currentConference.getEndCFPProp(), DateTime.Now) < 0 &&
                DateTime.Compare(this.currentConference.getEndCFPPaper(), DateTime.Now) < 0 &&
                DateTime.Compare(this.currentConference.getStartDate(), DateTime.Now) > 0)
            {
                btn_organizeSections.Enabled = true;
                btn_assignChairsToSections.Enabled = true;
            }
        }

        private void checkCurrentPhase()
        {
            // check if between end cfp and start conference
            if (DateTime.Compare(this.currentConference.getEndCFPProp(), DateTime.Now) < 0 &&
                DateTime.Compare(this.currentConference.getEndCFPPaper(), DateTime.Now) < 0 &&
                DateTime.Compare(this.currentConference.getStartDate(), DateTime.Now) > 0)
            {
                // decide which period exactly
                // Order: (2 days between each)
                // 1. Bid Period
                // 2. Review Period
                // 3. Organization Period
                // 4. Second Review Period
                DateTime endCFP = this.currentConference.getEndCFPProp();
                if(DateTime.Compare(endCFP, this.currentConference.getEndCFPPaper()) < 0)
                {
                    endCFP = this.currentConference.getEndCFPPaper();
                }
                DateTime currentDate = DateTime.Now;
                double dif = (currentDate - endCFP).TotalDays;
                if(dif < 0)
                {
                    lbl_periodBid.ForeColor = SystemColors.AppWorkspace;
                    lbl_periodReview1.ForeColor = SystemColors.AppWorkspace;
                    lbl_periodOrganization.ForeColor = SystemColors.AppWorkspace;
                    lbl_periodReview2.ForeColor = SystemColors.AppWorkspace;
                    lbl_periodBeforeConference.ForeColor = SystemColors.AppWorkspace;
                    return;
                }
                else if(dif <= 2)
                {
                    // Bid Period
                    lbl_periodBid.ForeColor = SystemColors.ControlText;
                    btn_assignChairsToSections.Enabled = false;
                    btn_joinSession.Enabled = false;
                    btn_organizeSections.Enabled = false;
                    btn_viewSchedule.Enabled = false;
                    btn_chat.Enabled = false;
                    btn_decide_verdict.Enabled = false;
                    btn_Review_Paper.Enabled = false;
                    btn_upload_presentation.Enabled = false;
                }
                else if(dif <= 4)
                {
                    // Review Period
                    lbl_periodReview1.ForeColor = SystemColors.ControlText;
                    btn_bidProposal.Enabled = false;
                    btn_organizeSections.Enabled = false;
                    btn_viewSchedule.Enabled = false;
                    btn_decide_verdict.Enabled = false;
                    btn_assignChairsToSections.Enabled = false;
                    btn_upload_presentation.Enabled = false;
                }
                else if (dif <= 6)
                {
                    // Organization Period
                    lbl_periodOrganization.ForeColor = SystemColors.ControlText;
                    btn_bidProposal.Enabled = false;
                    btn_decide_verdict.Enabled = false;
                    btn_Review_Paper.Enabled = false;
                    btn_upload_presentation.Enabled = false;
                }
                else if (dif <= 8)
                {
                    // Second Review Period
                    lbl_periodReview2.ForeColor = SystemColors.ControlText;
                    btn_assignChairsToSections.Enabled = false;
                    btn_bidProposal.Enabled = false;
                    btn_organizeSections.Enabled = false;
                    btn_chat.Enabled = true;
                    btn_upload_presentation.Enabled = false;
                    btn_upload_presentation.Enabled = false;
                }
                else
                {
                    // Before the conference starts
                    lbl_periodBeforeConference.ForeColor = SystemColors.ControlText;
                    btn_bidProposal.Enabled = false;
                    btn_organizeSections.Enabled = false;
                    btn_decide_verdict.Enabled = false;
                    btn_Review_Paper.Enabled = false;
                    btn_assignChairsToSections.Enabled = false;
                }
            }
        }

        private void btn_organizeConference_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_postponeConfDead_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostponeConference postponeConference = new PostponeConference(this.userService, this.loggedUser, this.currentConference);
            postponeConference.ShowDialog();
            this.Show();
            displayConferenceData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadFullPaper uploadFullPaper = new UploadFullPaper(this.loggedUser, this.currentConference, this.paperService, this.abstractPaperService, this.userService);
            uploadFullPaper.ShowDialog();
            this.Show();
        }

        private void btn_paperDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConferenceEntry paperDetails = new ConferenceEntry(this.loggedUser, this.currentConference, this.conferenceService, this.paperService, this.presentationService, this.abstractPaperService);
            paperDetails.ShowDialog();
            this.Show();
        }

        private void btn_uploadNewPaperVersion_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadNewPaperVersion uploadNewPaperVersion = new UploadNewPaperVersion(this.loggedUser, this.currentConference, this.paperService, this.abstractPaperService);
            uploadNewPaperVersion.ShowDialog();
            this.Show();
        }

        private void btn_uploadAbstractPaper_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadAbstractPaper uploadAbstractPaper = new UploadAbstractPaper(this.loggedUser, this.currentConference, this.conferenceService,this.abstractPaperService, this.userService);
            uploadAbstractPaper.ShowDialog();
            this.Show();
        }

        private void btn_uploadNewVersionAbstractPaper_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadNewAbstractVersion uploadNewAbstractVersion = new UploadNewAbstractVersion(this.abstractPaperService, this.loggedUser);
            uploadNewAbstractVersion.ShowDialog();
            this.Show();
        }

        private void btn_bidProposal_Click(object sender, EventArgs e)
        {
            this.Hide();
            bidProposal bidProposal = new bidProposal(loggedUser, currentConference, this.abstractPaperService);
            bidProposal.ShowDialog();
            this.Show();
        }

        private void btn_Review_Paper_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewPaper reviewPaper = new ReviewPaper(this.abstractPaperService, this.paperService, this.conferenceService, this.loggedUser);
            reviewPaper.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DecidePaperVerdict decidePaperVerdict = new DecidePaperVerdict(this.paperService,this.userService, currentConference);
            decidePaperVerdict.ShowDialog();
            this.Show();
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chat chat = new Chat(this.paperService,this.loggedUser,this.abstractPaperService, this.userService);
            chat.ShowDialog();
            this.Show();
        }

        private void btn_organizeSections_Click(object sender, EventArgs e)
        {
            
            OrganizeSectionsStepOne organizeSections = new OrganizeSectionsStepOne(this.conferenceService, this.abstractPaperService, this.currentConference);
            // check if conference sections have already been organized
            if (conferenceService.conferenceSectionsOrganized(currentConference.getId()))
            {
                MessageBox.Show("Conference sections have already been organized. Consult them by checking the conference schedule.");
            }
            else
            {
                this.Hide();
                organizeSections.ShowDialog();
                this.Show();
            }
        }

        private void btn_viewSchedule_Click(object sender, EventArgs e)
        {
            ViewSchedule viewSchedule = new ViewSchedule(conferenceService, abstractPaperService, userService, currentConference);
            if (!conferenceService.conferenceSectionsOrganized(currentConference.getId()))
            {
                MessageBox.Show("No schedule set yet. The sections must be organized first.");
            }
            else
            {
                this.Hide();
                viewSchedule.ShowDialog();
                this.Show();
            }
        }

        private void btn_assignChairsToSections_Click(object sender, EventArgs e)
        {
            AssignChairsToSections assignChairsToSections = new AssignChairsToSections(this.conferenceService, this.userService, this.currentConference);
            if (!conferenceService.conferenceSectionsOrganized(currentConference.getId()))
            {
                MessageBox.Show("The sections must be organized first.");
            }
            else if (conferenceService.chairsAssigned(currentConference.getId()))
            {
                MessageBox.Show("The session chairs have already been assigned. They may be consulted in the View Schedule functionality.");
            }
            else
            {
                this.Hide();
                assignChairsToSections.ShowDialog();
                this.Show();
            }
                
        }

        private void btn_joinSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinSession joinSession = new JoinSession(this.conferenceService, this.abstractPaperService, this.currentConference, this.loggedUser);
            joinSession.ShowDialog();
            this.Show();
        }

        private void btn_Send_Email_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendEmails sendEmails = new SendEmails(this.userService, this.emailService, this.conferenceService, this.currentConference, this.loggedUser);
            sendEmails.ShowDialog();
            this.Show();
        }

        private void btn_upload_presentation_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadPresentation uploadPresentation = new UploadPresentation(this.loggedUser, this.currentConference, this.presentationService, this.abstractPaperService, this.conferenceService, this.userService);
            uploadPresentation.ShowDialog();
            this.Show();
        }
    }
}
