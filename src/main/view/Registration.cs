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
    public partial class Registration : Form
    {
        UserService service;

        public Registration(UserService service)
        {
            this.service = service;
            InitializeComponent();
            this.additionalDisplayModifications();
        }

        private void additionalDisplayModifications()
        {
            // date time picker
            txtb_dob.CustomFormat = "dd / MM / yyyy";
            txtb_dob.Format = DateTimePickerFormat.Custom;

            // type of users combobox
            List<UserType> userTypes = service.getRegistrationUserTypes();
            cmbx_type.Items.Add("Please select one");
            for (int i = 0; i < userTypes.Count; i++)
            {
                cmbx_type.Items.Add(userTypes[i].getName());
            }
            cmbx_type.Items.Add("Other");
            cmbx_type.SelectedIndex = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.goToPreviousForm();
        }

        bool validate_data(string firstName, string lastName, string email, string userName, string password, string dob, string address, int type_id)
        {
            if (firstName.Length == 0 || lastName.Length == 0 || email.Length == 0 || userName.Length == 0 ||
                password.Length == 0 || dob.Length == 0 || address.Length == 0)
            {
                MessageBox.Show("All the fields marked with (*) are mandatory! Please insert the necessary data.");
                return false;
            }

            //check if firstname has at least three characters
            if (firstName.Length < 3)
            {
                MessageBox.Show("The first name is too short, please insert at least 3 characters.");
                return false;
            }

            //check if firstname has at least three characters
            if (lastName.Length < 3)
            {
                MessageBox.Show("The last name is too short, please insert at least 3 characters.");
                return false;
            }

            //check if username has at least three characters
            if (userName.Length < 3)
            {
                MessageBox.Show("Username is too short, please insert at least 3 characters.");
                return false;
            }

            //check if password has at least 6 characters
            if (password.Length < 6)
            {
                MessageBox.Show("Password is too short, please insert at least 6 characters.");
                return false;
            }

            //check if email is valid
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Please insert a valid e-mail!");
                return false;
            }

            //check if the user has at least 18 years old
            if(DateTime.Now.Subtract(txtb_dob.Value).TotalDays <= 6574)
            {
                MessageBox.Show("You must be at least 18 years old!");
                return false;
            }

            //check if the user already created an account
            try {
                this.service.loginUser(email,password); 
                MessageBox.Show("User already registered, please go to login!");
                return false;
            } 
            catch {}
            
            try {
                this.service.loginUser(userName,password); 
                MessageBox.Show("User already registered, please go to login!");
                return false;
            } 
            catch {}
            
            
           
            //check if birthdate is in the accepted format
            DateTime parsedDateTime;
            if (!DateTime.TryParseExact(dob, "dd / MM / yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None,  out parsedDateTime))
            {
                MessageBox.Show("Wrong format for birthday, use: dd / MM / yyyy (example : 07 / 06 / 2000)");
                return false;
            }
             
            //check if the type of user was selected
            if(type_id == 0)
            {
                MessageBox.Show("Type of user was not selected, please select one.");
                return false;
            }

             return true;
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            
            if (!validate_data(txtb_firstName.Text, txtb_lastName.Text, txtb_email.Text, txtb_username.Text, txtb_password.Text, txtb_dob.Text, txtb_address.Text, cmbx_type.SelectedIndex)) return;
            try
            {
                
                User user = new User(txtb_firstName.Text,txtb_lastName.Text,txtb_email.Text,txtb_username.Text,txtb_password.Text, txtb_dob.Value,txtb_address.Text, txtb_affiliation.Text, txtb_website.Text);
                UserType userType = new UserType(cmbx_type.Text, "");
                this.service.registerUser(user);
                this.service.setUserType(user, userType);
                MessageBox.Show("Account created successfully!");
                this.goToPreviousForm();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void goToPreviousForm()
        {
            this.Hide();
            Intro introForm = new Intro(this.service);
            introForm.ShowDialog();
            this.Dispose();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
