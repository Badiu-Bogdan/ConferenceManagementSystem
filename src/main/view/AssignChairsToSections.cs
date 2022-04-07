using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class AssignChairsToSections : Form
    {
        ConferenceService conferenceService;
        UserService userService;
        Conference currentConference;
        List<Topic> conferenceTopics;
        List<User> conferenceChairs;
        Dictionary<int, int> assignDict; // <section,chair>

        public AssignChairsToSections(ConferenceService conferenceService, UserService userService, Conference conference)
        {
            this.conferenceService = conferenceService;
            this.userService = userService;
            this.currentConference = conference;

            InitializeComponent();

            assignDict = new Dictionary<int, int>();
            loadConferenceTopics();
            getChairs();
            loadChairs();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void loadConferenceTopics()
        {
            // load only the topics whose sections are not empty
            cmbx_sections.Items.Clear();
            List<Topic> conferenceTopicsLocal = this.conferenceService.getTopicsForConference(currentConference.getId());
            conferenceTopics = new List<Topic>();
            Dictionary<int, List<List<int>>> scheduleDict = this.conferenceService.getSchedule(currentConference.getId());
            for (int i = 0; i < conferenceTopicsLocal.Count; i++)
            {
                if (scheduleDict.ContainsKey(conferenceTopicsLocal[i].Id))
                {
                    conferenceTopics.Add(conferenceTopicsLocal[i]);
                    cmbx_sections.Items.Add(conferenceTopicsLocal[i].Name);
                }
            }
        }

        private void getChairs()
        {
            conferenceChairs = new List<User>();
            List<(int Cid, int Usid)> lst = this.userService.getChairsForConference(currentConference.getId());
            for(int i = 0; i < lst.Count; i++)
            {
                conferenceChairs.Add(this.userService.getUser(lst[i].Usid));
            }            
        }

        private void loadChairs()
        {
            for (int i = 0; i < conferenceChairs.Count; i++)
            {
                listbx_chairs.Items.Add(conferenceChairs[i].FirstName + " " + conferenceChairs[i].LastName + " ("+conferenceChairs[i].Email+")");
            }
        }

        private void cmbx_sections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbx_sections.SelectedIndex >= 0 && listbx_chairs.SelectedIndex >= 0)
            {
                btn_assign.Enabled = true;

                // check if there is already someone assigned to this section
                int idSection = conferenceTopics[cmbx_sections.SelectedIndex].Id;
                if (assignDict.ContainsKey(idSection))
                {
                    User chair = getChairById(assignDict[idSection]);
                    lbl_assigned.Text = "Assigned: " + chair.FirstName + " " + chair.LastName;
                    btn_unassign.Enabled = true;
                }
                else
                {
                    lbl_assigned.Text = "Assigned: -";
                    btn_unassign.Enabled = false;
                }
            }
        }

        private User getChairById(int id)
        {
            return conferenceChairs.Find(c => c.Id == id);
        }

        private void listbx_chairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_assign.Enabled = false;
            if (listbx_chairs.SelectedIndex >= 0 && cmbx_sections.SelectedIndex >= 0)
            {
                btn_assign.Enabled = true;
            }
        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            
            int idChair = conferenceChairs[listbx_chairs.SelectedIndex].Id;
            int idSection = conferenceTopics[cmbx_sections.SelectedIndex].Id;

            // check if the user does not have a paper at that section
            if(conferenceService.isAuthorInSection(idChair, idSection, currentConference.getId()))
            {
                MessageBox.Show("This chair is an author for one of the papers in the selected section " +
                    "and can not be added as a session chair.");
                return;
            }

            if (assignDict.ContainsKey(idSection))
            {
                // already assigned
                assignDict[idSection] = idChair;
            }
            else
            {
                assignDict.Add(idSection, idChair);
            }

            // update the lbl
            User chair = getChairById(idChair);
            lbl_assigned.Text = "Assigned: " + chair.FirstName + " " + chair.LastName;
            btn_unassign.Enabled = true;

            // check if all sections have a session chair assigned
            if (allSectionsAssigned())
            {
                btn_save.Enabled = true;
            }
        }

        private bool allSectionsAssigned()
        {
            if(assignDict.Keys.Count == conferenceTopics.Count)
            {
                return true;
            }
            return false;
        }

        private void btn_unassign_Click(object sender, EventArgs e)
        {
            int idSection = conferenceTopics[cmbx_sections.SelectedIndex].Id;
            if (assignDict.ContainsKey(idSection))
            {
                assignDict.Remove(idSection);
                lbl_assigned.Text = "Assigned: -";
                btn_unassign.Enabled = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.conferenceService.assignChairsToSections(currentConference.getId(), assignDict);
            MessageBox.Show("Session chairs assigned successfully.");
            this.DialogResult = DialogResult.OK;
        }
    }
}
