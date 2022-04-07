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
    public partial class UploadPresentation : Form
    {
        PresentationService presentationService;
        AbstractPaperService abstractPaperService;
        ConferenceService conferenceService;
        UserService userService;
        User user;
        Conference conference;
        List<AbstractPaper> availableAbstracts;
        AbstractPaper selectedAbstract;
        string filePath = "";
        string fileFormat = "";

        public UploadPresentation(User user, Conference conference, PresentationService presentationService, AbstractPaperService abstractPaperService, ConferenceService conferenceService, UserService userService)
        {
            this.user = user;
            this.conference = conference;
            this.presentationService = presentationService;
            this.abstractPaperService = abstractPaperService;
            this.conferenceService = conferenceService;
            this.userService = userService;          
            InitializeComponent();
            loadAbstracts();

            this.panel_DragAndDrop.DragEnter += new DragEventHandler(presentation_DragEnter);
            this.panel_DragAndDrop.DragDrop += new DragEventHandler(presentation_DragDrop);
        }

        void presentation_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void presentation_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                if (file.EndsWith(".ppt") || file.EndsWith(".pptx"))
                {
                    lbl_selectedFile.Text = file;
                    lbl_selectedFile.ForeColor = System.Drawing.Color.Blue;
                    filePath = file;
                    fileFormat = System.IO.Path.GetExtension(file);
                    if (comboBox_abstract.Text.Length > 0)
                    {
                        btn_Upload_Presentation.Enabled = true;
                    }
                }
                else
                {
                    lbl_selectedFile.Text = "Invalid format. The presentation must be a .ppt or a .pptx file.";
                    lbl_selectedFile.ForeColor = System.Drawing.Color.Red;
                    btn_Upload_Presentation.Enabled = false;
                };
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void loadAbstracts()
        {
            comboBox_abstract.Items.Clear();
            availableAbstracts = this.abstractPaperService.getAbstractsWithoutPresentationForConference(conference.getId());
            for (int i = 0; i < availableAbstracts.Count; i++)
            {
                comboBox_abstract.Items.Add(availableAbstracts[i].Name);
            }
        }

        private void btn_Upload_Presentation_Click(object sender, EventArgs e)
        {
            try
            {
                string title = comboBox_abstract.Text;
                this.presentationService.uploadPresentation(filePath, title, user, selectedAbstract.Id, fileFormat);
                MessageBox.Show("Presentation uploaded successfully!");
                this.DialogResult = DialogResult.OK;
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_abstract_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_abstract.SelectedIndex >= 0)
            {
                if (filePath != "")
                {
                    btn_Upload_Presentation.Enabled = true;
                }
                this.selectedAbstract = this.availableAbstracts[comboBox_abstract.SelectedIndex];
            }
            else
            {
                btn_Upload_Presentation.Enabled = false;
            }
        }
    }
}
