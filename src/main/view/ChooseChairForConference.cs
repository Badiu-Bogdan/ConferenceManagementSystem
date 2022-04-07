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
    public partial class ChooseChairForConference : Form
    {
        UserService userService;
        ConferenceService conferenceService;
        User loggedUser;
        List<(int Cid, int Usid)> chairUsers;
        public ChooseChairForConference(UserService userService, ConferenceService conferenceService, User user)
        {
            this.userService = userService;
            this.conferenceService = conferenceService;
            this.loggedUser = user;
            InitializeComponent();
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

        private void ChooseChairForConference_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_load_users_Click(object sender, EventArgs e)
        {
            if (cmbox_conferences.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a conference from the list");
            }
            else
            {
                dataGridViewUsers.Rows.Clear();
                dataGridViewUsers.Refresh();
                int conference_id = Int32.Parse(cmbox_conferences.SelectedItem.ToString().Split(new string[] { ". " }, StringSplitOptions.None)[0]);

                Conference selectedConference = this.conferenceService.getConferenceForId(conference_id);
                this.chairUsers = this.userService.getChairsForConference(conference_id);

                if (selectedConference == null)
                    return;
                else
                {
                    try
                    {
                        foreach(User user in this.userService.getUsers())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridViewUsers);
                            row.Cells[0].Value = user.Id;
                            row.Cells[1].Value = user.Username;
                            if (chairUsers.Contains((conference_id, user.Id)))
                            {
                                row.Cells[2].Value = true;
                            }
                            else
                                row.Cells[2].Value = false;

                            dataGridViewUsers.Rows.Add(row);
                        }
                    }
                    catch (ServiceException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmbox_conferences.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a conference from the list");
            }
            if(cmbox_conferences == null)
            {
                MessageBox.Show("Error");
            }
            int conference_id = Int32.Parse(cmbox_conferences.SelectedItem.ToString().Split(new string[] { ". " }, StringSplitOptions.None)[0]);
            int contor = 0;
            foreach(DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if ((bool)row.Cells[2].Value == true)
                    contor++;
            }
            if(contor > 2)
            {
                MessageBox.Show("You cannot add more than 2 chairs! ");
                return;
            }
            foreach(DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if((bool)row.Cells[2].Value == true)
                {
                    //row.Cells[1] == user_id
                    int usid;
                    int.TryParse(row.Cells[0].Value.ToString(),out usid);
                    this.userService.addChair(conference_id, usid);
                }
            }
            MessageBox.Show("Added with succes! ");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(chairUsers == null || chairUsers.Count == 0)
            {
                MessageBox.Show("You cannot delete:there are no chairs!");
                return;
            }
            int conference_id = Int32.Parse(cmbox_conferences.SelectedItem.ToString().Split(new string[] { ". " }, StringSplitOptions.None)[0]);
            foreach(DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if((bool)row.Cells[2].Value == false)
                {
                    int usid;
                    int.TryParse(row.Cells[0].Value.ToString(), out usid);
                    if (chairUsers.Contains((conference_id, usid)) == true)
                    {
                        this.userService.removeChair(conference_id, usid);
                    }
                    
                }
            }
            MessageBox.Show("Deleted with succes! ");
        }
    }
}
