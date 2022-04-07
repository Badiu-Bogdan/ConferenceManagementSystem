using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.service
{
    public class ReviewerPaperService
    {
        protected ReviewRepository<long, ReviewerPaper> repository;

        public ReviewerPaperService(ReviewRepository<long, ReviewerPaper> new_repository)
        {
            this.repository = new_repository;
        }

        /*
         * Function used to see if a reviwer was allready assigned by a chair.
         * param: id_bid
         * returns : false if reviewer not assigned or true otherwise
         */
        public bool CheckIfReviewAllreadyAssigned(int id_bid)
        {
            bool result = false;
            List<ReviewerPaper> reviewerPapers = this.repository.findAll();
            foreach(ReviewerPaper reviewer in reviewerPapers)
            {
                if (reviewer.Idbid == id_bid)
                    result = true;
            }
            return result;
        }

        public void addReviewer(ReviewerPaper reviewer)
        {
            try
            {
                this.repository.save(reviewer);
            }
            catch(RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }
    }
}
