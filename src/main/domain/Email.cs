using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Email
    {
        private string id;
        private int idUser;
        private string consignee;
        private string subject;
        private string message;

        public Email(string id, int idUser, string consignee, string subject, string message)
        {
            this.id = id;
            this.idUser = idUser;
            this.consignee = consignee;
            this.subject = subject;
            this.message = message;
        }

        public Email(int idUser, string consignee, string subject, string message)
        {
            this.idUser = idUser;
            this.consignee = consignee;
            this.subject = subject;
            this.message = message;
        }

        // Getters and Setters
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        public string Consignee
        {
            get { return consignee; }
            set { consignee = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
