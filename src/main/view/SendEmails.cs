using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class SendEmails : Form
    {
        UserService userService;
        EmailService emailService;
        User loggedUser;
        ConferenceService conferenceService;
        Conference currentConference;
        List<User> acceptedAuthors;

        public SendEmails(UserService userService, EmailService emailService, ConferenceService conferenceService, Conference currentConference, User user)
        {
            this.userService = userService;
            this.emailService = emailService;
            this.conferenceService = conferenceService;
            this.currentConference = currentConference;
            this.loggedUser = user;
            InitializeComponent();
            loadAuthors();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void loadAuthors()
        {
            comboBox_authors.Items.Clear();
            acceptedAuthors = this.userService.getAuthors(currentConference.getId());
            for (int i = 0; i < acceptedAuthors.Count; i++)
            {
                comboBox_authors.Items.Add(acceptedAuthors[i].Email);
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txtb_subject.Text == "" || txtb_message.Text == "")
                MessageBox.Show("Please fill in all the necessary data!");
            else
            {
                try
                {
                    string consignee = comboBox_authors.SelectedItem.ToString();
                    string subject = txtb_subject.Text;
                    string message = txtb_message.Text;

                    this.emailService.sendEmail(loggedUser.Id, consignee, subject, message);
                    MessageBox.Show("Email sent successfully!");
                    
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
