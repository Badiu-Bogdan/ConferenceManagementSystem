using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Payment
    {
        private string id;
        private int idusername;
        private int idconference;
        private string cardNumber;
        private int cvv;
        private string cardholder;
        private DateTime expirationDate;

        public Payment(string id, int idusername, int idconference, string cardNumber, int cvv, string cardholder, DateTime expirationDate)
        {
            this.id = id;
            this.idusername = idusername;
            this.idconference = idconference;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.cardholder = cardholder;
            this.expirationDate = expirationDate;
        }
        public Payment(int idusername, int idconference, string cardNumber, int cvv, string cardholder, DateTime expirationDate)
        {
            this.idusername = idusername;
            this.idconference = idconference;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.cardholder = cardholder;
            this.expirationDate = expirationDate;
        }

        // Getters and Setters
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Idusername
        {
            get { return idusername; }
            set { idusername = value; }
        }
        public int Idconference
        {
            get { return idconference; }
            set { idconference = value; }
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public int CVV
        {
            get { return cvv; }
            set { cvv = value; }
        }
        public string Cardholder
        {
            get { return cardholder; }
            set { cardholder = value; }
        }
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
    }
}
