using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class User
    {
        private int id;

        private string firstName;
        private string lastName;
        private string email;
        private string username;
        private string password;
        private DateTime dob;
        private string address;
        private string affiliation;
        private string website;

        public User()
        {
        }

        public User(int id, string username)
        {
            this.id = id;
            this.username = username;
        }

        public User(int id, string firstName, string lastName, string email, string username, string password, DateTime dob, string address, string affiliation, string website)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.username = username;
            this.password = password;
            this.dob = dob;
            this.address = address;
            this.affiliation = affiliation;
            this.website = website;
        }

        public User(string firstName, string lastName, string email, string username, string password, DateTime dob, string address, string affiliation, string website)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.username = username;
            this.password = password;
            this.dob = dob;
            this.address = address;
            this.affiliation = affiliation;
            this.website = website;
        }


        // Getters and Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Affiliation
        {
            get { return affiliation; }
            set { affiliation = value; }
        }
        public string Website
        {
            get { return website; }
            set { website = value; }
        }
    }
}
