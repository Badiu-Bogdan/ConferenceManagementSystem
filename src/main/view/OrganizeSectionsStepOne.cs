using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class OrganizeSectionsStepOne : Form
    {
        ConferenceService conferenceService;
        AbstractPaperService abstractPaperService;
        Conference currentConference;
        List<AbstractPaper> acceptedPapers;
        List<Topic> conferenceTopics;
        List<Topic> eligibleTopics;
        Dictionary<int, List<AbstractPaper>> selectedPapersDict;

        public OrganizeSectionsStepOne(ConferenceService conferenceService, AbstractPaperService abstractPaperService, Conference currentConference)
        {
            this.conferenceService = conferenceService;
            this.abstractPaperService = abstractPaperService;
            this.currentConference = currentConference;
            this.selectedPapersDict = new Dictionary<int, List<AbstractPaper>>();

            InitializeComponent();

            loadAcceptedPapers();
            loadConferenceTopics();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void loadAcceptedPapers()
        {
            List<AbstractPaper> temp_abstractPapers = this.abstractPaperService.getAbstractsForConference(this.currentConference.getId());
            acceptedPapers = new List<AbstractPaper>();
            for(int i = 0; i < temp_abstractPapers.Count; i++)
            {
                if (temp_abstractPapers[i].IsAccepted == "1")
                {
                    acceptedPapers.Add(temp_abstractPapers[i]);
                    listbx_accepted.Items.Add(temp_abstractPapers[i].Id + ". " + temp_abstractPapers[i].Name);
                }
            }
        }

        private void loadConferenceTopics()
        {
            conferenceTopics = this.conferenceService.getTopicsForConference(currentConference.getId());
            for (int i = 0; i < conferenceTopics.Count; i++)
            {
                cmbx_selectedSections.Items.Add(conferenceTopics[i].Name);

                // initialize list in dictionary
                selectedPapersDict.Add(conferenceTopics[i].Id, new List<AbstractPaper>());
            }
        }

        private void listbx_accepted_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_sendToSection.Enabled = false;
            int idx = listbx_accepted.SelectedIndex;
            if(idx >= 0)
            {
                txtb_abstract.Text = this.acceptedPapers[idx].Abstractpaper;
                List<int> eligibleTopicIds = this.abstractPaperService.getTopicsForAbstract(this.acceptedPapers[idx].Id);
                eligibleTopics = new List<Topic>();
                for(int i = 0; i < conferenceTopics.Count; i++)
                {
                    if(eligibleTopicIds.FindIndex(tid => tid == conferenceTopics[i].Id) >= 0)
                    {
                        eligibleTopics.Add(conferenceTopics[i]);
                    }
                }

                cmbx_eligibleSections.Enabled = true;
                cmbx_eligibleSections.SelectedIndex = -1;
                cmbx_eligibleSections.Items.Clear();
                for(int i=0;i< eligibleTopics.Count; i++)
                {
                    cmbx_eligibleSections.Items.Add(eligibleTopics[i].Name);
                }
            }
        }

        private void cmbx_eligibleSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!btn_sendToSection.Enabled && cmbx_eligibleSections.SelectedIndex >= 0)
            {
                btn_sendToSection.Enabled = true;
            }
        }

        private void btn_sendToSection_Click(object sender, EventArgs e)
        {
            lbl_noPapers.Visible = false;
            int eligibleSectionSelectedIdx = cmbx_eligibleSections.SelectedIndex;
            int acceptedProposalIdx = listbx_accepted.SelectedIndex;

            // take id of selected topic and add the paper to that place in the dictionary
            // FIX HERE - Make sure you remove the proposed paper from the global list
            // or the topics if needed
            // FIX - STILL ADDING THE WRONG PAPER, DOES NOT SELECT THE RIGHT ONE
            int topicId = eligibleTopics[eligibleSectionSelectedIdx].Id;
            selectedPapersDict[topicId].Add(acceptedPapers[acceptedProposalIdx]);

            // remove paper from the global list as well
            acceptedPapers.RemoveAt(acceptedProposalIdx);

            // remove paper from the selected listbox
            listbx_accepted.Items.RemoveAt(acceptedProposalIdx);

            // refresh the right list (change the element from the combobox)
            // update the list on the right
            Topic selectedTopic = conferenceTopics.Find(ct => ct.Name == cmbx_eligibleSections.SelectedItem.ToString());
            int idxSelectedTopic = cmbx_selectedSections.Items.IndexOf(selectedTopic.Name);
            cmbx_selectedSections.SelectedIndex = idxSelectedTopic;
            listbx_selected.Items.Clear();

            List<AbstractPaper> selectedPapersForTopic = selectedPapersDict[conferenceTopics[idxSelectedTopic].Id];
            for (int i = 0; i < selectedPapersForTopic.Count; i++)
            {
                listbx_selected.Items.Add(selectedPapersForTopic[i].Id + ". " + selectedPapersForTopic[i].Name);
            }
            
            // reset the eligible topics combobox 
            cmbx_eligibleSections.Items.Clear();
            cmbx_eligibleSections.SelectedIndex = -1;
            cmbx_eligibleSections.Enabled = false;
            txtb_abstract.Text = "";

            // enable the next button in case there are no more papers to select
            if (listbx_accepted.Items.Count == 0)
            {
                btn_next.Enabled = true;
            }
        }

        private void btn_removeFromSection_Click(object sender, EventArgs e)
        {
            int idxToRemove = listbx_selected.SelectedIndex;
            int idSelectedTopic = conferenceTopics[cmbx_selectedSections.SelectedIndex].Id;

            // take the abstract paper
            AbstractPaper selectedAbstract = selectedPapersDict[idSelectedTopic][idxToRemove];

            // remove the element with this id from the dict
            selectedPapersDict[idSelectedTopic].RemoveAt(idxToRemove);

            // add paper back to the list of accepted papers
            acceptedPapers.Add(selectedAbstract);

            // update the list on the left
            listbx_accepted.Items.Clear();
            for (int i = 0; i < acceptedPapers.Count; i++)
            {
                listbx_accepted.Items.Add(acceptedPapers[i].Id + ". " + acceptedPapers[i].Name);
            }

            // update the list on the right
            listbx_selected.Items.Clear();
            int idxSelectedTopic = cmbx_selectedSections.SelectedIndex;
            if (idxSelectedTopic >= 0)
            {
                List<AbstractPaper> selectedPapersForTopic = selectedPapersDict[conferenceTopics[idxSelectedTopic].Id];
                for (int i = 0; i < selectedPapersForTopic.Count; i++)
                {
                    listbx_selected.Items.Add(selectedPapersForTopic[i].Id + ". " + selectedPapersForTopic[i].Name);
                }
            }

            txtb_abstract.Text = "";
        }

        private void listbx_selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbx_selected.SelectedIndex >= 0)
            {
                btn_removeFromSection.Enabled = true;

                // update abstract
                int idSelectedTopic = conferenceTopics[cmbx_selectedSections.SelectedIndex].Id;
                AbstractPaper chosenPaper = selectedPapersDict[idSelectedTopic][listbx_selected.SelectedIndex];
                txtb_abstract.Text = chosenPaper.Abstractpaper;
            }
        }

        private void cmbx_selectedSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_noPapers.Visible = false;
            btn_removeFromSection.Enabled = false;
            txtb_abstract.Text = "";
            listbx_selected.Items.Clear();
            int idxSelectedTopic = cmbx_selectedSections.SelectedIndex;
            if (idxSelectedTopic >= 0) {
                List<AbstractPaper> selectedPapersForTopic = selectedPapersDict[conferenceTopics[idxSelectedTopic].Id];
                for (int i = 0; i < selectedPapersForTopic.Count; i++)
                {
                    listbx_selected.Items.Add(selectedPapersForTopic[i].Id + ". " + selectedPapersForTopic[i].Name);
                }

                if(selectedPapersForTopic.Count == 0)
                {
                    lbl_noPapers.Visible = true;
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            OrganizeSectionsStepTwo organizeSectionsStepTwo = new OrganizeSectionsStepTwo(this.conferenceService, this.currentConference, selectedPapersDict);
            organizeSectionsStepTwo.Show();
            this.Close();
        }
    }
}
