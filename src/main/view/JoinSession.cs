using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class JoinSession : Form
    {
        ConferenceService conferenceService;
        AbstractPaperService abstractPaperService;
        Conference currentConference;
        User loggedUser;
        List<Topic> sessions;
        Dictionary<int, List<List<int>>> scheduleDict;
        Dictionary<int, AbstractPaper> abstractPapersDict;

        public JoinSession(ConferenceService conferenceService, AbstractPaperService abstractPaperService, Conference currentConference, User loggedUser)
        {
            this.conferenceService = conferenceService;
            this.abstractPaperService = abstractPaperService;
            this.currentConference = currentConference;
            this.loggedUser = loggedUser;

            InitializeComponent();

            loadConferenceSections();
            initializeAbstractPapersDict();
            constraintDateTimePicker();
            loadSchedule();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void loadConferenceSections()
        {
            sessions = this.conferenceService.getTopicsForConference(currentConference.getId());
            for (int i = 0; i < sessions.Count; i++)
            {
                cmbx_selectedSessions.Items.Add(sessions[i].Name);
            }
        }

        private void initializeAbstractPapersDict()
        {
            abstractPapersDict = new Dictionary<int, AbstractPaper>();
            List<AbstractPaper> abstractPapers = abstractPaperService.getAbstractsForConference(currentConference.getId());
            for (int i = 0; i < abstractPapers.Count; i++)
            {
                abstractPapersDict.Add(abstractPapers[i].Id, abstractPapers[i]);
            }
        }

        private int getCurrentTopicId()
        {
            if(cmbx_selectedSessions.SelectedIndex >= 0)
            {
                return this.sessions[cmbx_selectedSessions.SelectedIndex].Id;
            }
            return -1;
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            try
            {
                this.conferenceService.joinSession(this.currentConference.getId(), getCurrentTopicId(), this.loggedUser.Id);
                loadNumberAttendances();
                MessageBox.Show("Session joined successfully!");
            }catch(ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbx_selectedSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbx_selectedSessions.SelectedIndex >= 0)
            {
                btn_join.Enabled = true;
                // load how many attendees there are
                loadNumberAttendances();
                loadScheduleForDate(dtp_conference.Value);
            }
        }

        private void loadNumberAttendances()
        {
            int idTopic = getCurrentTopicId();
            lbl_usersJoined.Visible = true;
            int nrAtt = this.conferenceService.getNumberAttendances(this.currentConference.getId(), idTopic);
            this.lbl_usersJoined.Text = "Users joined: " + nrAtt.ToString();

            lbl_noMoreSpots.Visible = false;
            // if there are no more places, disable the join button
            Room assignedRoom = conferenceService.getRoomForTopic(this.currentConference.getId(), idTopic);
            if (assignedRoom != null && assignedRoom.Capacity <= nrAtt)
            {
                lbl_noMoreSpots.Visible = true;
                btn_join.Enabled = false;
            }
        }

        private void constraintDateTimePicker()
        {
            dtp_conference.MinDate = this.currentConference.getStartDate();
            dtp_conference.MaxDate = this.currentConference.getEndDate();
        }

        private void loadSchedule()
        {
            scheduleDict = this.conferenceService.getSchedule(this.currentConference.getId());
        }

        private void loadScheduleForDate(DateTime date)
        {
            if (cmbx_selectedSessions.SelectedIndex >= 0)
            {
                lbl_nothingToShow.Visible = true;
                listbx_schedule.Items.Clear();

                int idSelectedTopic = sessions[cmbx_selectedSessions.SelectedIndex].Id;

                if (!scheduleDict.ContainsKey(idSelectedTopic))
                {
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

        private AbstractPaper findAbstractById(int idAbstract)
        {
            return abstractPapersDict[idAbstract];
        }

        private void dtp_conference_ValueChanged(object sender, EventArgs e)
        {
            loadScheduleForDate(dtp_conference.Value);
        }
    }
}
