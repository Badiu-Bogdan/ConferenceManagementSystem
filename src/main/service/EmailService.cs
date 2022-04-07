using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.service
{
    public class EmailService
    {
        protected EmailRepository<long, Email> repository;

        public EmailService(EmailRepository<long, Email> repository)
        {
            this.repository = repository;
        }
        public void sendEmail(int idUser, string consignee, string subject, string message)
        {
            try
            {
                this.repository.sendEmail(idUser, consignee, subject, message);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }
    }
}
