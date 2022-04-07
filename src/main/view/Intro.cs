using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class Intro : Form
    {
        private UserService service;

        public Intro(UserService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registrationForm = new Registration(this.service);
            registrationForm.ShowDialog();
            this.Dispose();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtb_usernameOrEmail.TextLength == 0)
            {
                MessageBox.Show("Empty username/email field. Please try again.");
                return;
            }

            if (txtb_password.TextLength == 0)
            {
                MessageBox.Show("Empty password field. Please try again.");
                return;
            }

            try
            {
                User user = this.service.loginUser(txtb_usernameOrEmail.Text, txtb_password.Text);

                MessageBox.Show("Success!");
                this.Hide();
                ConferenceRepository<long, Conference> conferenceRepository = new ConferenceRepository<long, Conference>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                ConferenceService conferenceService = new ConferenceService(conferenceRepository);
                PaperRepository<long, Paper> paperRepository = new PaperRepository<long, Paper>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                PaperService paperService = new PaperService(paperRepository);
                ReviewRepository<long, ReviewerPaper> reviewRepository = new ReviewRepository<long, ReviewerPaper>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                ReviewerPaperService reviewerPaperService = new ReviewerPaperService(reviewRepository);

                AbstractPaperRepository<long, AbstractPaper> abstractPaperRepository = new AbstractPaperRepository<long, AbstractPaper>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                AbstractPaperService abstractPaperService = new AbstractPaperService(abstractPaperRepository);

                PaymentRepository<long, Payment> paymentRepository = new PaymentRepository<long, Payment>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                PaymentService paymentService = new PaymentService(paymentRepository);

                EmailRepository<long, Email> emailRepository = new EmailRepository<long, Email>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                EmailService emailService = new EmailService(emailRepository);

                PresentationRepository<long, Presentation> presentationRepository = new PresentationRepository<long, Presentation>(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                PresentationService presentationService = new PresentationService(presentationRepository);

                Main mainForm = new Main(this.service, conferenceService, paperService, abstractPaperService, paymentService, emailService, presentationService, user);
                mainForm.ShowDialog();
                this.Dispose();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}