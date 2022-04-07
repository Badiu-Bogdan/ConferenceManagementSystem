using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class ViewSchedule : Form
    {
        ConferenceService conferenceService;
        AbstractPaperService abstractPaperService;
        UserService userService;
        Conference currentConference;
        Dictionary<int, List<List<int>>> scheduleDict;
        List<Topic> conferenceTopics;
        Dictionary<int, AbstractPaper> abstractPapersDict;
        Dictionary<int, int> assignedChairs;

        public ViewSchedule(ConferenceService conferenceService, AbstractPaperService abstractPaperService, UserService userService, Conference conf)
        {
            this.conferenceService = conferenceService;
            this.abstractPaperService = abstractPaperService;
            this.userService = userService;
            this.currentConference = conf;

            InitializeComponent();

            loadSessionChairs();
            initializeAbstractPapersDict();
            loadConferenceTopics();
            constraintDateTimePicker();
            loadSchedule();
        }

        private void initializeAbstractPapersDict()
        {
            abstractPapersDict = new Dictionary<int, AbstractPaper>();
            List<AbstractPaper> abstractPapers = abstractPaperService.getAbstractsForConference(currentConference.getId());
            for(int i = 0; i < abstractPapers.Count; i++)
            {
                abstractPapersDict.Add(abstractPapers[i].Id, abstractPapers[i]);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToConferenceForm();
        }

        private void goToConferenceForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void constraintDateTimePicker()
        {
            dtp_conference.MinDate = this.currentConference.getStartDate();
            dtp_conference.MaxDate = this.currentConference.getEndDate();
        }

        private void loadConferenceTopics()
        {
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

        private void loadSchedule()
        {
            scheduleDict = this.conferenceService.getSchedule(this.currentConference.getId());
        }

        private void dtp_conference_ValueChanged(object sender, EventArgs e)
        {
            loadScheduleForDate(dtp_conference.Value);
        }

        private void cmbx_sections_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadScheduleForDate(dtp_conference.Value);
        }

        private void loadScheduleForDate(DateTime date)
        {
            if (cmbx_sections.SelectedIndex >= 0)
            {
                lbl_nothingToShow.Visible = true;
                listbx_schedule.Items.Clear();

                int idSelectedTopic = conferenceTopics[cmbx_sections.SelectedIndex].Id;

                // display the room for the selected section
                Room assignedRoom = conferenceService.getRoomForTopic(currentConference.getId(), idSelectedTopic);
                if(assignedRoom != null)
                {
                    lbl_room.Text = "Room: " + assignedRoom.Name + " (max capacity="+assignedRoom.Capacity+")";
                }

                // display the number of joined users
                int nrAtt = this.conferenceService.getNumberAttendances(this.currentConference.getId(), idSelectedTopic);
                lbl_usersJoined.Text = "Users joined: " + nrAtt;

                // display session chair
                displaySesionChair(idSelectedTopic);

                if (!scheduleDict.ContainsKey(idSelectedTopic))
                {
                    lbl_assignedSessionChair.Text = "No papers were chosen for this section";
                    return;
                }
                List<List<int>> values = scheduleDict[idSelectedTopic];

                listbx_schedule.Items.Clear();

                for (int i = 0; i < values.Count; i++)
                {
                    List<int> tuple = values[i];
                    if (date.Year == tuple[0] && date.Month == tuple[1] && date.Day == tuple[2])
                    {
                        AbstractPaper abstractPaper = findAbstractById(tuple[7]);
                        if (abstractPaper != null)
                        {
                            listbx_schedule.Items.Add(this.conferenceService.formatTimeFrame(tuple[3], tuple[4], tuple[5], tuple[6]) + " " + abstractPaper.Name);
                        }
                        lbl_nothingToShow.Visible = false;
                    }
                }
            }
        }

        private void displaySesionChair(int idSelectedTopic)
        {
            if (assignedChairs.ContainsKey(idSelectedTopic))
            {
                User chair = this.userService.getUser(assignedChairs[idSelectedTopic]);
                lbl_assignedSessionChair.Text = chair.FirstName + " " + chair.LastName + " (" + chair.Email + ")";
            }
            else
            {
                lbl_assignedSessionChair.Text = "None yet";
            }
        }

        private AbstractPaper findAbstractById(int idAbstract)
        {
            return abstractPapersDict[idAbstract];
        }

        private void loadSessionChairs()
        {
            assignedChairs = this.conferenceService.getAssignedSessionChairs(this.currentConference.getId());
        }
    }
}
