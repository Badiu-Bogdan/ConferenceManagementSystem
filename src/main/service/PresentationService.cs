using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.service
{
    public class PresentationService
    {
        protected PresentationRepository<long, Presentation> repository;

        public PresentationService(PresentationRepository<long, Presentation> repository)
        {
            this.repository = repository;
        }

        public void uploadPresentation(string path, string title, User user, int idAbstract, string fileFormat)
        {
            try
            {
                string idPresentation = this.repository.uploadPresentation(path, title, user, idAbstract, fileFormat);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
        Download a presentation for its abstract id
        Input: location - where to download it
               idAbstract - id of the abstract whose presentation must be downloaded
        Output: -
        */
        public void downloadPresentation(string location, int idAbstract)
        {
            try
            {
                Presentation presentationToDownload = this.repository.findPresentationForAbstract(idAbstract);
                this.repository.savePresentationToFileSystem(presentationToDownload, location);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }
    }
}
