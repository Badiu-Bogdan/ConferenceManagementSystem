using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using ConferenceManagementSystem.src.main.service;
using ConferenceManagementSystem.src.main.domain;

namespace ConferenceManagementSystem.src.main.view
{
    public partial class QueryOtherReviews : Form
    {
        ConferenceService conferenceService;
        int idProposal;
        public QueryOtherReviews(ConferenceService conferenceService, int idProposal)
        {
            this.conferenceService = conferenceService;
            this.idProposal = idProposal;
            InitializeComponent();
            loadOtherReviews();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void loadOtherReviews()
        {
            List<Review> reviews = conferenceService.queryOtherReviews(idProposal);

            for(int i = 0; i < reviews.Count; i++)
            {
                lstbx_reviews.Items.Add(reviews[i].Verdict);
            }
        }
    }
}
