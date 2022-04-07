using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class OrganizeConference : Form
    {
        private ConferenceService service;
        private User currentUser;

        public OrganizeConference(ConferenceService service, User user)
        {
            this.service = service;
            this.currentUser = user;
            InitializeComponent();
            this.loadConferenceTopics();

            setDateTimeNow();
        }

        private void setDateTimeNow()
        {
            txtb_confDateStart.Value = DateTime.Now;
            txtb_confDateEnd.Value = DateTime.Now;
            txtb_confCFPStart.Value = DateTime.Now;
            txtb_confCFPEndProp.Value = DateTime.Now;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_organizeConference_Click(object sender, EventArgs e)
        {
            
            DateTime startDateCFP = DateTime.Parse(txtb_confCFPStart.Text);
            DateTime endDateCFPProp = DateTime.Parse(txtb_confCFPEndProp.Text);
            DateTime endDateCFPPaper = DateTime.Parse(txtb_confCFPEndPaper.Text);
            DateTime startDateConf = DateTime.Parse(txtb_confDateStart.Text);
            DateTime endDateConf = DateTime.Parse(txtb_confDateEnd.Text);
            bool requiresPaper = chcbx_allowPapers.Checked;
            List<Topic> topics = new List<Topic>();
            for (int i=0;i<listbx_topicsSelected.Items.Count; i++){
                Topic t = new Topic();
                t.Name = listbx_topicsSelected.Items[i].ToString();
                topics.Add(t);
            }
            
            if(this.validate_data(txtb_confTitle.Text, txtb_description.Text, startDateConf, endDateConf, startDateCFP, endDateCFPProp, endDateCFPPaper, topics))
            {
                this.service.organizeConference(txtb_confTitle.Text, txtb_description.Text, startDateCFP, endDateCFPProp, endDateCFPPaper, startDateConf, endDateConf, topics, this.currentUser, requiresPaper);
                MessageBox.Show("Successfully organized a conference.");
                this.goToPreviousForm();
            }
            
        }

        private void loadConferenceTopics()
        {
            try
            {
                List<Topic> topics = this.service.getTopics();
                for(int i = 0; i < topics.Count; i++)
                {
                    listbx_topics.Items.Add(topics[i].Name);
                }
            }catch(ServiceException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        bool validate_data(string title, string description, DateTime startDate, DateTime endDate, DateTime startCFP, DateTime endCFPProp, DateTime endCFPPaper, List<Topic> topics)
        {
            if (title.Length == 0 || description.Length == 0)
            {
                MessageBox.Show("All the fields are mandatory! Please insert the necessary data.");
                return false;
            }

            // check if the conference title has less than 3 characters
            if(title.Length < 3)
            {
                MessageBox.Show("The conference title must have more than three characters.");
                return false;
            }

            // check if the conference title is taken
            try
            {
                Conference conf = this.service.getConferenceForTitle(title);
                if (conf != null)
                {
                    MessageBox.Show("Conference name taken.");
                    return false;
                }
            }
            catch(ServiceException e) {
                MessageBox.Show(e.Message);
                return false;
            }

            // check dates
            if(DateTime.Compare(startDate, DateTime.Now) < 0)
            {
                MessageBox.Show("Starting conference date must be after today.");
                return false;
            }
            if (DateTime.Compare(startDate, endDate) > 0)
            {
                MessageBox.Show("Ending conference date must be after the conference startng date.");
                return false;
            }
            if (DateTime.Compare(startCFP, DateTime.Now) < 0)
            {
                MessageBox.Show("Starting CFP date must be after today.");
                return false;
            }
            if (DateTime.Compare(startCFP, endCFPProp) > 0)
            {
                MessageBox.Show("Ending CFP date for proposals must be after the Call for Papers startng date.");
                return false;
            }
            if (DateTime.Compare(startCFP, endCFPPaper) > 0)
            {
                MessageBox.Show("Ending CFP date for papers must be after the Call for Papers startng date.");
                return false;
            }
            if (DateTime.Compare(endCFPProp, startDate) > 0 || DateTime.Compare(endCFPPaper, startDate) > 0)
            {
                MessageBox.Show("The Call for Papers period must be before the conference starting date.");
                return false;
            }

            // check topics list
            if(topics.Count == 0)
            {
                MessageBox.Show("At least a topic must be chosen.");
                return false;
            }

            return true;
        }

        private void selectTopic()
        {
            if (listbx_topics.SelectedIndex >= 0)
            {
                listbx_topicsSelected.Items.Add(listbx_topics.SelectedItem.ToString());
                listbx_topics.Items.Remove(listbx_topics.SelectedItem);
            }
        }

        private void deselectTopic()
        {
            if (listbx_topicsSelected.SelectedIndex >= 0)
            {
                listbx_topics.Items.Add(listbx_topicsSelected.SelectedItem.ToString());
                listbx_topicsSelected.Items.Remove(listbx_topicsSelected.SelectedItem);
            }
        }

        private void btn_addTopic_Click(object sender, EventArgs e)
        {
            selectTopic();
        }

        private void btn_removeTopic_Click(object sender, EventArgs e)
        {
            deselectTopic();
        }

        private void listbx_topics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectTopic();
        }

        private void listbx_topicsSelected_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            deselectTopic();
        }
    }
}
