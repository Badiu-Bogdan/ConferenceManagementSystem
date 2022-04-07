using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class OrganizeSectionsStepTwo : Form
    {
        ConferenceService conferenceService;
        Conference currentConference;
        Dictionary<int, List<AbstractPaper>> selectedPapersDict;
        Dictionary<int, AbstractPaper> abstractPapersDict;
        List<Topic> conferenceTopics;
        Dictionary<int, List<List<int>>> scheduleDict; // <idTopic, [year,month,day,startHour,startMin,endHour,endMin,idAbstract]>

        public OrganizeSectionsStepTwo(ConferenceService conferenceService, Conference currentConference, Dictionary<int, List<AbstractPaper>> selectedPapersDict)
        {
            this.conferenceService = conferenceService;
            this.currentConference = currentConference;
            this.selectedPapersDict = selectedPapersDict;

            InitializeComponent();

            initializeAbstractPapersDict();
            loadConferenceTopics();
            constraintDateTimePicker();
            initializeScheduleDict();
        }

        private void initializeAbstractPapersDict()
        {
            abstractPapersDict = new Dictionary<int, AbstractPaper>();
            foreach (KeyValuePair<int, List<AbstractPaper>> entry in selectedPapersDict)
            {
                for(int i = 0; i < entry.Value.Count; i++)
                {
                    abstractPapersDict.Add(entry.Value[i].Id,entry.Value[i]);
                }
            }
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            this.goToConferenceForm();
        }

        private void goToConferenceForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void loadConferenceTopics()
        {
            conferenceTopics = this.conferenceService.getTopicsForConference(currentConference.getId());
            for (int i = 0; i < conferenceTopics.Count; i++)
            {
                cmbx_sections.Items.Add(conferenceTopics[i].Name);
            }
        }

        private void constraintDateTimePicker()
        {
            dtp_conference.MinDate = this.currentConference.getStartDate();
            dtp_conference.MaxDate = this.currentConference.getEndDate();

            dtp_selectedDate.MinDate = this.currentConference.getStartDate();
            dtp_selectedDate.MaxDate = this.currentConference.getEndDate();

            // set values times for the start/end time frames
            dtp_selectedStart.Value = DateTime.Parse(this.currentConference.getStartDate().ToString("HH:mm"));
            dtp_selectedEnd.Value = DateTime.Parse(this.currentConference.getEndDate().ToString("HH:mm"));
        }

        private void initializeScheduleDict()
        {
            scheduleDict = new Dictionary<int, List<List<int>>>();

            foreach(KeyValuePair<int, List<AbstractPaper>> entry in selectedPapersDict)
            {
                scheduleDict.Add(entry.Key, new List<List<int>>());
            }
        }

        private bool checkScheduleOkay(DateTime dateTime, DateTime startTime, DateTime endTime)
        {

            if(DateTime.Compare(startTime, endTime) >= 0)
            {
                return false;
            }

            int idSelectedTopic = conferenceTopics[cmbx_sections.SelectedIndex].Id;
            List<List<int>> values = new List<List<int>>(scheduleDict[idSelectedTopic].ToArray());
            int year, month, day, startHour, startMin, endHour, endMin;
            string startTimeComp, endTimeComp;
            for (int i=0;i< values.Count; i++)
            {
                List<int> tuple = values[i];
                year = tuple[0];
                month = tuple[1];
                day = tuple[2];
                if(dateTime.Year == year && dateTime.Month == month && dateTime.Day == day)
                {
                    startHour = tuple[3];
                    startMin = tuple[4];
                    endHour = tuple[5];
                    endMin = tuple[6];

                    //A.end >= B.start AND A.start <= B.end
                    startTimeComp = startHour.ToString() + ":" + startMin.ToString();
                    endTimeComp = endHour.ToString() + ":" + endMin.ToString();
                    if (DateTime.Compare(DateTime.Parse(startTimeComp), endTime) < 0 &&
                        DateTime.Compare(DateTime.Parse(endTimeComp), startTime) > 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void displayPapersForSection()
        {
            lbl_noPapers.Visible = false;
            listbx_selected.Items.Clear();
            int idxSelectedTopic = cmbx_sections.SelectedIndex;
            if (idxSelectedTopic >= 0)
            {
                List<AbstractPaper> selectedPapersForTopic = selectedPapersDict[conferenceTopics[idxSelectedTopic].Id];
                for (int i = 0; i < selectedPapersForTopic.Count; i++)
                {
                    listbx_selected.Items.Add(selectedPapersForTopic[i].Id + ". " + selectedPapersForTopic[i].Name);
                }

                if (selectedPapersForTopic.Count == 0)
                {
                    lbl_noPapers.Visible = true;
                }
            }
        }

        private void cmbx_sections_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_remove.Enabled = false;
            displayPapersForSection();
            loadScheduleForDate(dtp_conference.Value);
        }

        private void dtp_conference_ValueChanged(object sender, EventArgs e)
        {
            btn_remove.Enabled = false;

            this.loadScheduleForDate(dtp_conference.Value);

            // change date for scheduling
            dtp_selectedDate.Value = dtp_conference.Value;
        }

        private String formatTimeFrame(int startHour, int startMin, int endHour, int endMin)
        {
            String format = "";
            if(startHour < 10)
            {
                format += "0";
            }
            format += startHour.ToString();
            format += ":";
            if (startMin < 10)
            {
                format += "0";
            }
            format += startMin.ToString();
            format += "-";
            if (endHour < 10)
            {
                format += "0";
            }
            format += endHour.ToString();
            format += ":";
            if (endMin < 10)
            {
                format += "0";
            }
            format += endMin.ToString();
            return format;
        }

        private void loadScheduleForDate(DateTime date)
        {
            if (cmbx_sections.SelectedIndex >= 0)
            {
                lbl_noSchedule.Visible = false;
                int idSelectedTopic = conferenceTopics[cmbx_sections.SelectedIndex].Id;
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
                            listbx_schedule.Items.Add(formatTimeFrame(tuple[3], tuple[4], tuple[5], tuple[6]) + " " + abstractPaper.Name);
                        }
                    }
                }

                if(listbx_schedule.Items.Count == 0)
                {
                    lbl_noSchedule.Visible = true;
                }
            }
        }

        private AbstractPaper findAbstractById(int idAbstract)
        {
            return abstractPapersDict[idAbstract];
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            // Check if there are no other schedules at the same time
            if (!checkScheduleOkay(dtp_selectedDate.Value, dtp_selectedStart.Value, dtp_selectedEnd.Value))
            {
                MessageBox.Show("Invalid time frame. It might be taken or the date/time is invalid.");
                return;
            }
            // then store the data in the dictionary
            int selectedIdx = listbx_selected.SelectedIndex;
            int idSelectedTopic = conferenceTopics[cmbx_sections.SelectedIndex].Id;
            AbstractPaper selectedAbstract = selectedPapersDict[idSelectedTopic][selectedIdx];
            List<int> values = new List<int>();
            values.Add(dtp_selectedDate.Value.Year);
            values.Add(dtp_selectedDate.Value.Month);
            values.Add(dtp_selectedDate.Value.Day);
            values.Add(dtp_selectedStart.Value.Hour);
            values.Add(dtp_selectedStart.Value.Minute);
            values.Add(dtp_selectedEnd.Value.Hour);
            values.Add(dtp_selectedEnd.Value.Minute);
            values.Add(selectedAbstract.Id);

            scheduleDict[idSelectedTopic].Add(values);

            dtp_conference.Value = dtp_selectedDate.Value;

            // in the end refresh the schedule
            loadScheduleForDate(dtp_selectedDate.Value);

            // remove from the left side
            selectedPapersDict[idSelectedTopic].RemoveAt(selectedIdx);
            displayPapersForSection();

            btn_schedule.Enabled = false;

            // enable organize conferences button if there are no more papers
            if (noMorePapers())
            {
                btn_organizeSections.Enabled = true;
            }
        }

        private bool noMorePapers()
        {
            foreach (KeyValuePair<int, List<AbstractPaper>> entry in selectedPapersDict)
            {
                if(entry.Value.Count != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void listbx_selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbx_selected.SelectedIndex >= 0)
            {
                btn_schedule.Enabled = true;
            }
        }

        private void listbx_schedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbx_schedule.SelectedIndex >= 0)
            {
                btn_remove.Enabled = true;

                // set the start and end times to this one
                int idSelectedTopic = conferenceTopics[cmbx_sections.SelectedIndex].Id;
                List<int> tuple = scheduleDict[idSelectedTopic][listbx_schedule.SelectedIndex];
                dtp_selectedStart.Value = DateTime.Parse(tuple[3].ToString() + ":" + tuple[4].ToString());
                dtp_selectedEnd.Value = DateTime.Parse(tuple[5].ToString() + ":" + tuple[6].ToString());
            }
            else
            {
                btn_remove.Enabled = false;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int idxSchedule = listbx_schedule.SelectedIndex;
            if(idxSchedule == -1)
            {
                return;
            }
            int idSelectedTopic = conferenceTopics[cmbx_sections.SelectedIndex].Id;

            List<List<int>> schedulesForTopic = scheduleDict[idSelectedTopic];
            List<int> matchingTuple = schedulesForTopic[idxSchedule]; //findTupleForDateSection(dtp_conference.Value, idSelectedTopic);
            int idAbstractPaper = matchingTuple[7];
            AbstractPaper apToRemove = findAbstractById(idAbstractPaper);

            // add the value to the left list
            selectedPapersDict[idSelectedTopic].Add(apToRemove);
            displayPapersForSection();

            // remove it from the right side
            scheduleDict[idSelectedTopic].RemoveAt(idxSchedule);
            this.loadScheduleForDate(dtp_conference.Value);

            btn_organizeSections.Enabled = false;
            btn_remove.Enabled = false;
        }

        private void btn_organizeSections_Click(object sender, EventArgs e)
        {
            this.conferenceService.saveSchedule(scheduleDict, currentConference.getId());
            MessageBox.Show("Conference sections organized successfully.");

            // redirect to choosing the rooms
            OrganizeSectionsStepThree organizeConferenceStepThree = new OrganizeSectionsStepThree(this.conferenceService, this.currentConference);
            organizeConferenceStepThree.ShowDialog();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
