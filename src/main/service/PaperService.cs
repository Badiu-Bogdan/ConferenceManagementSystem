using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using System.Collections.Generic;

namespace ConferenceManagementSystem.src.main.service
{
    public class PaperService
    {
        protected PaperRepository<long, Paper> repository;

        public PaperService(PaperRepository<long, Paper> repository)
        {
            this.repository = repository;
        }

        public List<Paper> getPapersForAuthor(int authorId)
        {
            List<Paper> papers = this.repository.findAll();
            papers = papers.FindAll(paper =>
            {
                List<int> authorIds = this.repository.getAuthorIdsForPaper(paper.getId());
                return authorIds.Find(id => id == authorId) > 0;
            });
            return papers;
        }

        public void uploadFullPaper(string path, string title, User user, int idAbstract, string fileFormat)
        {
            try
            {
                string idPaper = this.repository.uploadFullPaper(path, title, user, idAbstract, fileFormat);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void changeAcceptance(int idAbstract)
        {
            try
            {
                this.repository.changeAcceptance(idAbstract);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void uploadNewPaperVersion(string path, int abstractId, string fileFormat)
        {
            try
            {
                Paper paper = this.repository.findPaperForAbstract(abstractId);
                this.repository.uploadNewPaperVersion(path, paper.getId(), abstractId, fileFormat);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void acceptProposal(int idAbstract)
        {
            try
            {
                this.repository.acceptProposal(idAbstract);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void rejectProposal(int idAbstract)
        {
            try
            {
                this.repository.rejectProposal(idAbstract);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
        Download a paper for its abstract id
        Input: location - where to download it
               idAbstract - id of the abstract whose paper must be downloaded
        Output: -
        */
        public void downloadPaper(string location, int idAbstract)
        {
            try
            {
                Paper paperToDownload = this.repository.findPaperForAbstract(idAbstract);
                this.repository.savePaperToFilesystem(paperToDownload, location);
            }
            catch(RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<Paper> getPapersforReviewer(int reviewerId)
        {
            return this.repository.getPapersforReviewer(reviewerId);
        }

        public List<Paper> getPapersforReviewerDiscussion(int reviewerId)
        {
            return this.repository.getPapersforReviewerDiscussion(reviewerId);
        }

        public List<Paper> getPapersInContradictory()
        {
            return this.repository.getPapersInContradictory();
        }

        public void updateReviewPaper(string comment, int reviewId, string paperTitle)
        {
            this.repository.updateReviewPaper(comment, reviewId, paperTitle);
        }

        
    }
}
