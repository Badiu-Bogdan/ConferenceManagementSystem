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
    public partial class Chat : Form
    {
        PaperService paperService;
        AbstractPaperService abstractPaperService;
        User user;
        UserService userService;
        List<Paper> papers;

        public Chat(PaperService paperService, User user, AbstractPaperService abstractPaperService, UserService userService)
        {
            this.paperService = paperService;
            this.abstractPaperService = abstractPaperService;
            this.user = user;
            this.userService = userService;
            InitializeComponent();
            this.displayPapers();
        }
        private void displayPapers()
        {
            papers = this.paperService.getPapersforReviewerDiscussion(this.user.Id);
            papers.ForEach(paper =>
            {
                cmbox_papers.Items.Add(paper.getTitle());
            });
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void cmbox_papers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbox_abstractPaper.Text = this.abstractPaperService.getAbstractForId(papers[cmbox_papers.SelectedIndex].getIdAbstract()).Abstractpaper;
            txtbox_chat.Text = this.userService.getCommentsForChat(papers[cmbox_papers.SelectedIndex].getTitle());
            btn_downloadPaper.Enabled = true;
            txtbox_comment.Enabled = true;
            btn_accept.Enabled = true;
            btn_reject.Enabled = true;
            btn_addComment.Enabled = true;
        }
        private void btn_downloadPaper_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the location where to download the file";
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                try
                {
                    this.paperService.downloadPaper(folderBrowserDialog.SelectedPath, this.abstractPaperService.getAbstractForId(papers[cmbox_papers.SelectedIndex].getIdAbstract()).Id);
                    MessageBox.Show("Paper Downloaded Successfully.");
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            this.userService.updateVerdictAfterDiscussion(1, papers[cmbox_papers.SelectedIndex].getTitle(), this.user);
            MessageBox.Show("Paper was successfully accepted!");
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            this.userService.updateVerdictAfterDiscussion(0, papers[cmbox_papers.SelectedIndex].getTitle(), this.user);
            MessageBox.Show("Paper was successfully rejected!");
        }

        private void btn_addComment_Click(object sender, EventArgs e)
        {
            this.userService.updateChat(txtbox_comment.Text, papers[cmbox_papers.SelectedIndex].getTitle(), this.user);
            txtbox_chat.Text = this.userService.getCommentsForChat(papers[cmbox_papers.SelectedIndex].getTitle());

            MessageBox.Show("Comment was successfully added!");
        }
    }
}
