using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class PostponeConference : Form
    {
        UserService service;
        User loggedUser;
        Conference conference;

        public PostponeConference(UserService service, User user, Conference conference)
        {
            this.service = service;
            this.loggedUser = user;
            this.conference = conference;
            InitializeComponent();

            // load the current deadlines
            dtp_cfpDeadlineProp.Text = conference.getEndCFPProp().ToString();
            dtp_ConferenceProp.Value = conference.getEndCFPProp();

            dtp_cfpDeadlinePaper.Text = conference.getEndCFPPaper().ToString();
            dtp_ConferencePaper.Value = conference.getEndCFPPaper();
        }

        private void btn_postpone_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime newDeadline = dtp_ConferencePaper.Value;
                if(DateTime.Compare(newDeadline, this.conference.getEndCFPPaper()) < 0)
                {
                    MessageBox.Show("The new date can not be before the old one.");
                    return;
                }
                this.service.postponeConference(this.conference.getId(), "Paper", newDeadline);
                MessageBox.Show("Deadline Postponed Successfully!");
                this.dtp_cfpDeadlinePaper.Value = newDeadline;
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_postponeProp_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime newDeadline = dtp_ConferenceProp.Value;
                if (DateTime.Compare(newDeadline, this.conference.getEndCFPProp()) < 0)
                {
                    MessageBox.Show("The new date can not be before the old one.");
                    return;
                }
                this.service.postponeConference(this.conference.getId(), "Proposal", newDeadline);
                MessageBox.Show("Deadline Postponed Successfully!");
                this.dtp_cfpDeadlineProp.Value = newDeadline;
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
