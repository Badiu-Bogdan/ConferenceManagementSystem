using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class UploadFullPaper : Form
    {
        PaperService paperService;
        AbstractPaperService abstractPaperService;
        UserService userService;
        User user;
        Conference conference;
        List<AbstractPaper> availableAbstracts;
        AbstractPaper selectedAbstract;
        string filePath = "";
        string fileFormat = "";

        public UploadFullPaper(User user, Conference conference, PaperService paperService, AbstractPaperService abstractPaperService, UserService userService)
        {
            this.user = user;
            this.conference = conference;
            this.paperService = paperService;
            this.abstractPaperService = abstractPaperService;
            this.userService = userService;
            InitializeComponent();

            this.displayProposals();

            this.panel_DragDrop.DragEnter += new DragEventHandler(fullPaper_DragEnter);
            this.panel_DragDrop.DragDrop += new DragEventHandler(fullPaper_DragDrop);
        }

        void displayProposals()
        {
            availableAbstracts = new List<AbstractPaper>();
            List<AbstractPaper> papers = this.abstractPaperService.getAbstractsWithoutPaperForAuthor(user.Id);
            papers.ForEach(paper =>
            {
                availableAbstracts.Add(paper);
                cmbox_proposals.Items.Add(paper.Name);
            });
        }

        void fullPaper_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void fullPaper_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) 
                if (file.EndsWith(".pdf") || file.EndsWith(".docx")) { 
                    lbl_selectedFile.Text = file;
                    lbl_selectedFile.ForeColor = System.Drawing.Color.Blue;
                    filePath = file;
                    fileFormat = System.IO.Path.GetExtension(file);
                    if (txtb_paperTitle.Text.Length > 0 && cmbox_proposals.SelectedIndex >= 0)
                    {
                        btn_uploadFullPaper.Enabled = true;
                    }
                } 
                else { 
                    lbl_selectedFile.Text = "Invalid format. The paper must be a .pdf or a .docx file.";
                    lbl_selectedFile.ForeColor = System.Drawing.Color.Red;
                    btn_uploadFullPaper.Enabled = false;
                };
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_uploadFullPaper_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtb_paperTitle.Text;
                this.paperService.uploadFullPaper(filePath, title, user, selectedAbstract.Id, fileFormat);
                MessageBox.Show("Paper uploaded successfully!");
                goToPreviousForm();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtb_paperTitle_TextChanged(object sender, EventArgs e)
        {
            if(txtb_paperTitle.Text.Length > 0)
            {
                if (filePath != "" && cmbox_proposals.SelectedIndex >= 0)
                {
                    btn_uploadFullPaper.Enabled = true;
                }
            }
            else
            {
                btn_uploadFullPaper.Enabled = false;
            }
        }

        private void cmbox_proposals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbox_proposals.SelectedIndex >= 0)
            {
                selectedAbstract = availableAbstracts[cmbox_proposals.SelectedIndex];
            }
            
            if (cmbox_proposals.SelectedIndex >= 0 && filePath != "" && txtb_paperTitle.Text.Length > 0)
            {
                btn_uploadFullPaper.Enabled = true;
            }
            else
            {
                btn_uploadFullPaper.Enabled = false;
            }
        }
    }
}
