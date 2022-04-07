using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.service
{
    public class PaymentService
    {
        protected PaymentRepository<long, Payment> repository;

        public PaymentService(PaymentRepository<long, Payment> repository)
        {
            this.repository = repository;
        }

        public void payRegistrationFee(int idusername, int idconference, string cardnumber, int cvv, string cardholder, DateTime expirationdate)
        {
            try
            {
                this.repository.payRegistrationFee(idusername, idconference, cardnumber, cvv, cardholder, expirationdate);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public bool userPaidConference(int idUser, int idConference)
        {
            try
            {
                return this.repository.userPaidConference(idUser, idConference);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

    }
}
