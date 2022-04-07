using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class Main : Form
    {
        UserService userService;
        ConferenceService conferenceService;
        PaperService paperService;
        AbstractPaperService abstractPaperService;
        PaymentService paymentService;
        ReviewerPaperService reviewerPaperService;
        EmailService emailService;
        PresentationService presentationService;
        User loggedUser;

        public Main(UserService userService, ConferenceService conferenceService, PaperService paperService, AbstractPaperService abstractPaperService, PaymentService paymentService, EmailService emailService, PresentationService presentationService, User user)
        {
            this.userService = userService;
            this.conferenceService = conferenceService;
            this.paperService = paperService;
            this.abstractPaperService = abstractPaperService;
            this.paymentService = paymentService;
            this.emailService = emailService;
            this.presentationService = presentationService;
            this.reviewerPaperService = reviewerPaperService;
            this.loggedUser = user;
            InitializeComponent();
            this.displayUserSpecificData();
            this.displayConferenceList();
        }

        private void displayConferenceList()
        {
            cmbox_conferences.Items.Clear();
            List<Conference> conferences = conferenceService.getConferences();
            conferences.ForEach(conf =>
            {
                cmbox_conferences.Items.Add(conf.getId().ToString() + ". " + conf.getTitle());
            });
        }

        private void displayUserSpecificData()
        {
            lbl_username.Text = "Logged in as: " + this.loggedUser.Username;

            List<UserType> userTypes = this.userService.getUserTypesForUser(this.loggedUser);
            cmbx_type.Items.Add("Other");
            for (int i = 0; i < userTypes.Count; i++)
            {
                cmbx_type.Items.Add(userTypes[i].getName());
            }
            cmbx_type.SelectedIndex = 0;

            panel_tbd.Visible = false;
        }

        private void displayAdminSpecificData()
        {
            panel_tbd.Visible = true;
            btn_assign_reviewers_to_paper.Enabled = true;
        }

        private void displayChairSpecificData()
        {
            btn_assign_reviewers_to_paper.Enabled = true;
        }

        private void displaySCMSpecificData()
        {
            panel_tbd.Visible = true;
        }

        private void displayOtherSpecificData()
        {
            panel_tbd.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            this.loggedUser = null;
            this.Hide();
            Intro introForm = new Intro(this.userService);
            introForm.ShowDialog();
            this.Dispose();
        }

        /*
         When the current user type changes, the display changes as well
        according to the chosen type
        if type = Admin => all options are visible + admin-only features
        if type = Steering Committee Member => only his options are available
        if type = Other => all other options are visible
         */
        private void cmbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbx_type.Text)
            {
                case "Admin":
                    this.displayAdminSpecificData();
                    break;
                case "Steering Committee Member":
                    this.displaySCMSpecificData();
                    break;
                case "Chair":
                    this.displayChairSpecificData();
                    break;
                case "Other":
                    this.displayOtherSpecificData();
                    break;

                default:
                    break;
            }
        }

        private void btn_chooseCoChairForConf_Click(object sender, EventArgs e)
        {

        }

        private void btn_organizeConfEd_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrganizeConference organizeConferenceForm = new OrganizeConference(this.conferenceService, this.loggedUser);
            organizeConferenceForm.ShowDialog();
            this.Show();
            this.displayConferenceList();
            this.btn_goToConference.Enabled = false;
        }

        private void btn_goToConference_Click(object sender, EventArgs e)
        {
            if (cmbox_conferences.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a conference from the list");
            }
            else
            {
                string conferenceTitle = cmbox_conferences.SelectedItem.ToString().Split(new string[] { ". " }, StringSplitOptions.None)[1];
               
                Conference selectedConference = this.conferenceService.getConferenceForTitle(conferenceTitle);

                // check if the conference fee was paid
                if (!paymentService.userPaidConference(this.loggedUser.Id, selectedConference.getId())){
                    // check if the user is a pc member for that conference
                    if (!conferenceService.isPCMemberForConference(selectedConference.getId(), this.loggedUser.Id))
                    {
                        MessageBox.Show("The conference fee must be paid first.");
                        return;
                    }
                }

                this.Hide();
                ConferenceForm conferenceForm = new ConferenceForm(this.userService, this.conferenceService, this.abstractPaperService,this.paperService, this.emailService, this.presentationService, this.loggedUser, selectedConference);
                conferenceForm.ShowDialog();
                this.Show();
            }
        }


        private void btn_chooseChairForConf_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseChairForConference chooseChairForConference = new ChooseChairForConference(this.userService, this.conferenceService, this.loggedUser);
            chooseChairForConference.ShowDialog();
            this.Show();
        }

        private void cmbox_conferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbox_conferences.SelectedIndex >= 0)
            {
                btn_goToConference.Enabled = true;
                btn_payRegistrationFee.Enabled = true;
            }
        }

        private void button_payRegistrationFee_Click(object sender, EventArgs e)
        {
            if (cmbox_conferences.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a conference from the list");
            }
            else
            {
                string conferenceTitle = cmbox_conferences.SelectedItem.ToString().Split(new string[] { ". " }, StringSplitOptions.None)[1];

                Conference selectedConference = this.conferenceService.getConferenceForTitle(conferenceTitle);
                this.Hide();
                PayRegistrationFee payRegistrationFeeForm = new PayRegistrationFee(this.userService, this.conferenceService, this.paymentService, this.loggedUser, selectedConference);
                payRegistrationFeeForm.ShowDialog();
                this.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_assign_reviewers_to_paper_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignReviewersToPapers assignReviewersToPapers = new AssignReviewersToPapers(this.conferenceService, this.abstractPaperService, this.reviewerPaperService, cmbox_conferences.Text);
            assignReviewersToPapers.ShowDialog();
            this.Show();
        }

        private void btn_invitePCMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvitePCMembers invitePCMembers = new InvitePCMembers(this.userService, this.conferenceService, this.loggedUser);
            invitePCMembers.ShowDialog();
            this.Show();
        }
    }
}