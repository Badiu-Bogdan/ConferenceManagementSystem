using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class bidProposal : Form
    {
        User loggedUser;
        Conference currentConference;
        AbstractPaperService abastractPaperService;
        List<AbstractPaper> abstractPapers;
        AbstractPaper selectedAbstract;
        List<Verdict> verdicts;

        public bidProposal(User currentUser, Conference currentConf, AbstractPaperService abastractPaperService)
        {
            this.loggedUser = currentUser;
            this.currentConference = currentConf;
            this.abastractPaperService = abastractPaperService;
            InitializeComponent();

            loadProposals();
            loadVerdicts();
        }

        // load the proposals in the proposals combobox
        private void loadProposals()
        {
            abstractPapers = abastractPaperService.getAbstractsForBids(this.currentConference.getId(), this.loggedUser.Id);
            abstractPapers.ForEach(abs =>
            {
                 cmbox_proposals.Items.Add(abs.Name);
            });
        }

        // load verdict options
        private void loadVerdicts()
        {
            verdicts = abastractPaperService.getVerdicts();
            verdicts.ForEach(verdict =>
            {
                cmbox_verdicts.Items.Add(verdict.getVerdict());
            });
        }

        // retrieve the selected verdict
        private Verdict getSelectedVerdict()
        {
            if(cmbox_verdicts.SelectedIndex != -1)
            {
                return this.verdicts[cmbox_verdicts.SelectedIndex];
            }
            return null;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_bid_Click(object sender, EventArgs e)
        {
            try
            {
                Verdict selectedVerdict = getSelectedVerdict();
                this.abastractPaperService.bidProposal(loggedUser, selectedAbstract, selectedVerdict);
                MessageBox.Show("Proposal bid successfully");

                // reset the display
                btn_bid.Enabled = false;
                cmbox_proposals.SelectedIndex = -1;
                cmbox_verdicts.SelectedIndex = -1;
                txtb_abstract.Text = "";
            }
            catch(ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbox_proposals_SelectedIndexChanged(object sender, EventArgs e)
        {
            // remember the selected abstract
            int selectedIndex = cmbox_proposals.SelectedIndex;
            if (selectedIndex == -1)
            {
                selectedAbstract = null;
                return;
            }

            selectedAbstract = abstractPapers[selectedIndex];

            // check if the proposal was already bid for
            Verdict givenVerdict = this.abastractPaperService.getVerdictForProposalByReviewer(loggedUser, selectedAbstract);
            if (givenVerdict != null)
            {
                lbl_alreadyBid.Visible = true;

                // load given verdict
                cmbox_verdicts.SelectedIndex = findIndexForVerdict(givenVerdict);

                // disable the bid button
                btn_bid.Enabled = false;

                // disable the verdict
                cmbox_verdicts.Enabled = false;
            }
            else
            {
                lbl_alreadyBid.Visible = false;
                cmbox_verdicts.Enabled = true;
            }

            // load the paper abstract
            txtb_abstract.Text = selectedAbstract.Abstractpaper;


        }

        private int findIndexForVerdict(Verdict verdict)
        {
            return this.verdicts.FindIndex(v => v.getId() == verdict.getId());
        }

        private void cmbox_verdicts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable the bid button
            btn_bid.Enabled = true;
        }
    }
}
