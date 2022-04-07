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
    public partial class OrganizeSectionsStepThree : Form
    {
        ConferenceService conferenceService;
        Conference currentConference;
        List<Topic> sessions;
        List<Room> rooms;
        Dictionary<Topic, Room> assignedRooms = new Dictionary<Topic, Room>();
        Dictionary<int, List<List<int>>> schedule;

        public OrganizeSectionsStepThree(ConferenceService conferenceService, Conference currentConference)
        {
            this.conferenceService = conferenceService;
            this.currentConference = currentConference;
            this.schedule = conferenceService.getSchedule(currentConference.getId());

            InitializeComponent();

            loadConferenceSections();
            loadRooms();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void loadConferenceSections()
        {
            List<Topic> temp_sessions = this.conferenceService.getTopicsForConference(currentConference.getId());
            this.sessions = new List<Topic>();
            for (int i = 0; i < temp_sessions.Count; i++)
            {
                // load only sessions with papers
                if (schedule.ContainsKey(temp_sessions[i].Id))
                {
                    cmbx_sections.Items.Add(temp_sessions[i].Name);
                    sessions.Add(temp_sessions[i]);
                }
            }
        }

        public void loadRooms()
        {
            rooms = this.conferenceService.getRooms();
            for (int i = 0; i < rooms.Count; i++)
            {
                listbx_rooms.Items.Add(rooms[i].Name + " : " + rooms[i].Capacity);
            }
        }

        private void listbx_rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbx_rooms.SelectedIndex >= 0)
            {
                // update labels
                Room selectedRoom = this.rooms[listbx_rooms.SelectedIndex];

                if (cmbx_sections.SelectedIndex >= 0)
                {
                    Topic selectedTopic = this.sessions[cmbx_sections.SelectedIndex];
                    if (assignedRooms.ContainsKey(selectedTopic))
                    {
                        btn_assignRoom.Enabled = false;
                        btn_unassignRoom.Enabled = true;
                    }
                    else
                    {
                        btn_assignRoom.Enabled = true;
                        btn_unassignRoom.Enabled = false;
                    }
                }
            }
        }

        private void cmbx_sections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbx_sections.SelectedIndex >= 0)
            {
                Topic selectedTopic = this.sessions[cmbx_sections.SelectedIndex];
                this.changeLabelsForTopic(selectedTopic);
            }
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            // TODO: save the results to the db
            this.conferenceService.assignRoomsToSessions(currentConference.getId(), assignedRooms);
            MessageBox.Show("Rooms successfully assigned.");
            this.DialogResult = DialogResult.OK;
        }

        private void btn_assignRoom_Click(object sender, EventArgs e)
        {
            Topic selectedTopic = this.sessions[cmbx_sections.SelectedIndex];
            Room selectedRoom = this.rooms[listbx_rooms.SelectedIndex];

            // check if the room can fit everybody
            int nrAtt = this.conferenceService.getNumberAttendances(this.currentConference.getId(), selectedTopic.Id);
            if (nrAtt <= selectedRoom.Capacity)
            {
                this.assignedRooms.Add(selectedTopic, selectedRoom);
                this.rooms.Remove(selectedRoom);
                listbx_rooms.Items.RemoveAt(listbx_rooms.SelectedIndex);

                if (this.assignedRooms.Count == this.sessions.Count)
                {
                    btn_complete.Enabled = true;
                }
                this.changeLabelsForTopic(selectedTopic);
            }
            else
            {
                MessageBox.Show("The selected room does not fit all the participants");
            }
        }

        private void btn_unassignRoom_Click(object sender, EventArgs e)
        {
            Topic selectedTopic = this.sessions[cmbx_sections.SelectedIndex];
            Room assignedRoom = assignedRooms[selectedTopic];
            assignedRooms.Remove(selectedTopic);
            this.rooms.Add(assignedRoom);
            this.listbx_rooms.Items.Add(assignedRoom.Name + " : " + assignedRoom.Capacity);
            btn_complete.Enabled = false;

            this.changeLabelsForTopic(selectedTopic);
        }

        private void changeLabelsForTopic(Topic selectedTopic)
        {
            if (assignedRooms.ContainsKey(selectedTopic))
            {
                Room assignedRoom = assignedRooms[selectedTopic];
                lbl_assignedRoom.Text = "Assigned Room: " + assignedRoom.Name;
                lbl_capacity.Text = "Capacity: " + assignedRoom.Capacity;

                btn_assignRoom.Enabled = false;
                btn_unassignRoom.Enabled = true;
            }
            else
            {
                lbl_assignedRoom.Text = "Assigned Room: no room assigned yet";
                lbl_capacity.Text = "Capacity: no room assigned yet";

                if (listbx_rooms.SelectedIndex >= 0)
                {
                    btn_assignRoom.Enabled = true;
                }
                btn_unassignRoom.Enabled = false;
            }

            int nrAtt = this.conferenceService.getNumberAttendances(this.currentConference.getId(), selectedTopic.Id);
            lbl_usersJoined.Text = "Users Joined: " + nrAtt;
        }
    }
}
