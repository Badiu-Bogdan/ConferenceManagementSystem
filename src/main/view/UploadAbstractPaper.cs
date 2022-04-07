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
    public partial class UploadAbstractPaper : Form
    {
        AbstractPaperService abstractPaperService;
        UserService userService;
        User user;
        Conference conference;
        ConferenceService conferenceService;
        public UploadAbstractPaper(User user, Conference conference, ConferenceService conferenceService, AbstractPaperService abstractPaperService, UserService userService)
        {
            this.user = user;
            this.conference = conference;
            this.conferenceService = conferenceService;
            this.abstractPaperService = abstractPaperService;
            this.userService = userService;
            InitializeComponent();
            loadTopics();
            loadAuthors();
        }


        private void loadAuthors()
        {
            try
            {
                List<User> authors = this.userService.getUsers();
                for (int i = 0; i < authors.Count; i++)
                {
                    if (authors[i].Id != this.user.Id)
                    {
                        listbx_authors.Items.Add(authors[i].Id.ToString() + "." + authors[i].FirstName + " " + authors[i].LastName);
                    }
                }
            }
            catch (ServiceException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void loadTopics()
        {
            try
            {
                List<string> topics = this.conferenceService.getTopicsIds(this.conference.getId());
                for (int i = 0; i < topics.Count; i++)
                {
                    listbx_topics.Items.Add(topics[i]);
                }
            }
            catch (ServiceException e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
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


        private void selectAuthor()
        {
            if (listbx_authors.SelectedIndex >= 0)
            {
                listbx_authorsSelected.Items.Add(listbx_authors.SelectedItem.ToString());
                listbx_authors.Items.Remove(listbx_authors.SelectedItem);
            }
        }

        private void deselectAuthor()
        {
            if (listbx_authorsSelected.SelectedIndex >= 0)
            {
                listbx_authors.Items.Add(listbx_authorsSelected.SelectedItem.ToString());
                listbx_authorsSelected.Items.Remove(listbx_authorsSelected.SelectedItem);
            }
        }


        private void listbx_authors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectAuthor();
        }

        private void listbx_authorsSelected_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            deselectAuthor();
        }

        private void listbx_topics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectTopic();
        }

        private void listbx_topicsSelected_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            deselectTopic();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void btn_addAuthor_Click_1(object sender, EventArgs e)
        {
            selectAuthor();

        }

        private void btn_removeAuthor_Click_1(object sender, EventArgs e)
        {
            deselectAuthor();

        }

        private void btn_addTopic_Click_1(object sender, EventArgs e)
        {
            selectTopic();

        }

        private void btn_removeTopic_Click_1(object sender, EventArgs e)
        {
            deselectTopic();

        }

        private void btn_uploadAbstractPaper_Click(object sender, EventArgs e)
        {
            if (listbx_topicsSelected.Items.Count==0 || txtb_abstractTitle.Text == "" || txtb_keywords.Text == "" || txtb_abstractMetaInfo.Text == "" || txtb_abstractPaper.Text=="")
                MessageBox.Show("Please fill in all the necessary data!");
            else if (txtb_abstractTitle.Text.Length < 3)
            {
                MessageBox.Show("The abstract title must have at least 3 characters");
            }else if (txtb_abstractPaper.Text.Length < 20)
            {
                MessageBox.Show("The abstract must have at least 20 characters");
            }
            else
            {
                try
                {

                    string title = txtb_abstractTitle.Text;
                    string keywords = txtb_keywords.Text;
                    string metainfo = txtb_abstractMetaInfo.Text;
                    string abstractPaper = txtb_abstractPaper.Text;

                    List<int> authorIds = new List<int>();
                    for (int i = 0; i < listbx_authorsSelected.Items.Count; i++)
                    {
                        string entry = listbx_authorsSelected.Items[i].ToString();
                        int id = Int32.Parse(entry.Split('.')[0]);
                        authorIds.Add(id);
                    }

                    List<int> topicIds = new List<int>();
                    for (int i = 0; i < listbx_topicsSelected.Items.Count; i++)
                    {
                        string entry = listbx_topicsSelected.Items[i].ToString();
                        int id = Int32.Parse(entry.Split('.')[0]);
                        topicIds.Add(id);
                    }


                    this.abstractPaperService.uploadAbstractPaper(user, title, abstractPaper, keywords, metainfo, conference.getId(), authorIds, topicIds);
                    MessageBox.Show("Abstract Paper uploaded successfully!");
                    goToPreviousForm();
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

      
    }
}
