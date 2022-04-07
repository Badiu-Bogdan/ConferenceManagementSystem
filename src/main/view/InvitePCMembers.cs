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
    public partial class InvitePCMembers : Form
    {
        UserService userService;
        ConferenceService conferenceService;
        User loggedUser;
        List<Conference> conferences;
        List<User> users;

        public InvitePCMembers(UserService userService, ConferenceService conferenceService, User loggedUser)
        {
            this.userService = userService;
            this.conferenceService = conferenceService;
            this.loggedUser = loggedUser;

            InitializeComponent();

            this.displayConferenceList();
            this.displayUsersList();
        }

        private void displayConferenceList()
        {
            cmbox_conferences.Items.Clear();
            conferences = conferenceService.getConferences();
            conferences.ForEach(conf =>
            {
                cmbox_conferences.Items.Add(conf.getId().ToString() + ". " + conf.getTitle());
            });
        }

        private void displayUsersList()
        {
            cmbx_users.Items.Clear();
            users = userService.getUsers();
            users.ForEach(user =>
            {
                if (user.Id != this.loggedUser.Id)
                {
                    cmbx_users.Items.Add(user.FirstName + " " + user.LastName + " (" + user.Email + ")");
                }
            });

            // remove yourself from the users list
            this.users.Remove(users.Find(usr => usr.Id == this.loggedUser.Id));

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbox_conferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_conferences.SelectedIndex >= 0)
            {
                enableInvite();
            }
        }
        
        private void cmbx_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_users.SelectedIndex >= 0)
            {
                enableInvite();
            }
        }

        private void enableInvite()
        {
            if (cmbox_conferences.SelectedIndex >= 0 && cmbx_users.SelectedIndex >= 0)
            {
                btn_invite.Enabled = true;
            }
        }

        private void btn_invite_Click(object sender, EventArgs e)
        {
            if (cmbox_conferences.SelectedIndex >= 0 && cmbx_users.SelectedIndex >= 0)
            {
                Conference selectedConference = this.conferences[cmbox_conferences.SelectedIndex];
                User selectedUser = this.users[cmbx_users.SelectedIndex];

                // check if the current user is a chair for the selected conference
                List<(int Cid, int Usid)> chairs = userService.getChairsForConference(selectedConference.getId());
                if(chairs.FindIndex(ch => ch.Usid == this.loggedUser.Id) < 0)
                {
                    MessageBox.Show("You are not a chair for the selected conference.");
                    return;
                }

                // check if this user is already a pc member for the selected conference
                List<PCMember> pcMembersForConference = conferenceService.getPCMembersForConference(selectedConference.getId());
                if(pcMembersForConference.Find(pcm => pcm.Id == selectedUser.Id) != null)
                {
                    MessageBox.Show("The user is already a PC member for the selected conference.");
                    return;
                }

                // check if the user is a chair for that conference
                if (chairs.FindIndex(ch => ch.Usid == selectedUser.Id) >= 0)
                {
                    MessageBox.Show("The selected user is a chair for the selected conference and can not be selected as a PC member.");
                    return;
                }

                conferenceService.insertPCMemberForConference(selectedConference.getId(), selectedUser.Id);
                MessageBox.Show("Successfully invited user " + selectedUser.FirstName + " " +
                    selectedUser.LastName + " to conference " + selectedConference.getTitle() + ".");
            }
            else
            {
                MessageBox.Show("All comboboxes must contain a value.");
            }
        }
    }
}
