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
    public partial class PayRegistrationFee : Form
    {
        UserService userService;
        ConferenceService conferenceService;
        PaymentService paymentService;
        User loggedUser;
        Conference currentConference;
        bool isTextBox1OK = false;
        bool isTextBox2OK = false;
        bool isTextBox3OK = false;
        public PayRegistrationFee(UserService userService, ConferenceService conferenceService, PaymentService paymentService, User user, Conference conference)
        {
            this.userService = userService;
            this.conferenceService = conferenceService;
            this.paymentService = paymentService;
            this.loggedUser = user;
            this.currentConference = conference;
            InitializeComponent();

            dtp_expDate.MinDate = DateTime.Now;
            dtp_expDate.MaxDate = DateTime.Today.AddYears(4);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            if (txtb_cardnumber.Text == "" || txtb_cvv.Text == "" || txtb_cardholder.Text == "")
                MessageBox.Show("Please fill in all the necessary data!");
            else
            {
                try
                {
                    string cardnumber = txtb_cardnumber.Text;
                    int cvv = Int32.Parse(txtb_cvv.Text);
                    string cardholder = txtb_cardholder.Text;
                    DateTime expirationdate = dtp_expDate.Value;

                    this.paymentService.payRegistrationFee(loggedUser.Id, currentConference.getId(), cardnumber, cvv, cardholder, expirationdate);
                    MessageBox.Show("Registration fee paid successfully!");
                    this.DialogResult = DialogResult.OK;
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void txtb_cardnumber_TextChanged(object sender, EventArgs e)
        {
            if (txtb_cardnumber.Text.Length > 0)
            {
                if (IsDigitsOnly(txtb_cardnumber.Text) == false)
                {
                    isTextBox1OK = false;
                }
                else if (txtb_cardnumber.Text.Length == 16)
                {
                    isTextBox1OK = true;
                    
                }
                else
                    isTextBox1OK = false;
            }
            else
                isTextBox1OK = false;
            check_boxes();
        }

        private void txtb_cvv_TextChanged(object sender, EventArgs e)
        {
            if (txtb_cvv.Text.Length > 0)
            {
                if (IsDigitsOnly(txtb_cvv.Text) == false)
                {
                    isTextBox2OK = false;
                }
                else if (txtb_cvv.Text.Length == 3)
                {
                    isTextBox2OK = true;
                    
                }
                else
                    isTextBox2OK = false;
            }
            else
                isTextBox2OK = false;
            check_boxes();
        }

        private void txtb_cardholder_TextChanged(object sender, EventArgs e)
        {
            if (txtb_cardholder.Text.Length > 0)
            {
                isTextBox3OK = true;
                
            }
            else
                isTextBox3OK = false;
            check_boxes();
        }

        private void check_boxes()
        {
            if (isTextBox1OK && isTextBox2OK && isTextBox3OK)
                pay_button.Enabled = true;
            else
                pay_button.Enabled = false;
        }
    }
}
