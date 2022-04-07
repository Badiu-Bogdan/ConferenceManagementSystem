using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class UploadNewPaperVersion : Form
    {
        PaperService paperService;
        AbstractPaperService abstractPaperService;
        User user;
        Conference conference;
        AbstractPaper selectedAbstractPaper;
        string filePath = "";
        string fileFormat = "";

        public UploadNewPaperVersion(User user, Conference conference, PaperService paperService, AbstractPaperService abstractPaperService)
        {
            this.user = user;
            this.conference = conference;
            this.paperService = paperService;
            this.abstractPaperService = abstractPaperService;
            InitializeComponent();

            this.panel_DragDrop.DragEnter += new DragEventHandler(fullPaper_DragEnter);
            this.panel_DragDrop.DragDrop += new DragEventHandler(fullPaper_DragDrop);
            this.loadPapersCombobox();
        }

        private void loadPapersCombobox()
        {
            List<AbstractPaper> abstractPapers = abstractPaperService.getAbstractsForAuthor(user.Id);
            abstractPapers.ForEach(abstr =>
            {
                cmbox_papers.Items.Add(abstr.Name);
            });
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        private void goToPreviousForm()
        {
            this.DialogResult = DialogResult.OK;
        }

        void fullPaper_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void fullPaper_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                if (file.EndsWith(".pdf") || file.EndsWith(".docx"))
                {
                    lbl_selectedFile.Text = file;
                    lbl_selectedFile.ForeColor = System.Drawing.Color.Blue;
                    filePath = file;
                    fileFormat = System.IO.Path.GetExtension(file);
                    if (cmbox_papers.SelectedIndex >= 0)
                    {
                        checkPaperWasUploadedBefore();
                    }
                }
                else
                {
                    lbl_selectedFile.Text = "Invalid format. The paper must be a .pdf or a .docx file.";
                    lbl_selectedFile.ForeColor = System.Drawing.Color.Red;
                    btn_uploadNewPaperVersion.Enabled = false;
                };
        }

        private void btn_uploadNewPaperVersion_Click(object sender, EventArgs e)
        {
            try
            {
                this.paperService.uploadNewPaperVersion(filePath, selectedAbstractPaper.Id, fileFormat);
                MessageBox.Show("Paper version uploaded successfully!");
                goToPreviousForm();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbox_papers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbox_papers.SelectedIndex >= 0)
            {
                
                List<AbstractPaper> abstractPapers = abstractPaperService.getAbstractsForAuthor(user.Id);
                selectedAbstractPaper = abstractPapers[cmbox_papers.SelectedIndex];
            }

            if (cmbox_papers.SelectedIndex >= 0 && filePath != "")
            {
                // check if the selected proposal has an associated paper
                checkPaperWasUploadedBefore();
            }
        }

        private void checkPaperWasUploadedBefore()
        {
            if (abstractPaperService.abstractHasPaper(selectedAbstractPaper.Id))
            {
                btn_uploadNewPaperVersion.Enabled = true;
                lbl_noPaperForAbstract.Visible = false;
            }
            else
            {
                btn_uploadNewPaperVersion.Enabled = false;
                lbl_noPaperForAbstract.Visible = true;
            }
        }
    }
}
