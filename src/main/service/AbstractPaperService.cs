using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using System.Collections.Generic;

namespace ConferenceManagementSystem.src.main.service
{
    public class AbstractPaperService
    {
        protected AbstractPaperRepository<long, AbstractPaper> repository;

        public AbstractPaperService(AbstractPaperRepository<long, AbstractPaper> repository)
        {
            this.repository = repository;
        }


        public List<AbstractPaper> getAbstracts()
        {
            List<AbstractPaper> papers = this.repository.findAll();
            return papers;
        }

        public List<AbstractPaper> getAbstractsForConference(int idConference)
        {
            List<AbstractPaper> papers = this.repository.findAll().FindAll(p => p.IdConference == idConference);
            return papers;
        }
        public string getTopicsForAnAbstract(int idAbstract)
        {
            try
            {
                List<string> topics =  this.repository.getTopicsForAnAbstract(idAbstract);
                string result = "";
                topics.ForEach(topic =>
                {
                    result = result + topic + System.Environment.NewLine;
                });
                return result;
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public string getAuthorsForAbstract(int idAbstract)
        {
            try
            {
                List<string> authors = this.repository.getAuthorsForAbstract(idAbstract);
                string result = "";
                authors.ForEach(author =>
                {
                    result = result + author + System.Environment.NewLine;
                });
                return result;
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }


        public List<AbstractPaper> getAbstractsForBids(int idConference, int userId)
        {
            List<AbstractPaper> papers = this.repository.getAbstractsForBids(userId).FindAll(p => p.IdConference == idConference);
            return papers;
        }

        public List<AbstractPaper> getAbstractsForAuthor(int authorId)
        {
            List<AbstractPaper> abstracts = this.repository.findAll();
            abstracts = abstracts.FindAll(paper =>
            {
                List<int> authorIds = this.repository.getAuthorIdsForPaperAbstract(paper.Id);
                return authorIds.Find(id => id == authorId) > 0;
            });
            return abstracts;
        }

        public List<AbstractPaper> getAbstractsWithoutPaperForAuthor(int authorId)
        {
            List<AbstractPaper> abstracts = this.getAbstractsForAuthor(authorId);
            abstracts = abstracts.FindAll(abstr =>
            {
                return !this.repository.abstractHasPaper(abstr.Id);
            });
            return abstracts;
        }

        public void uploadAbstractPaper(User user, string name, string abstractPaper, string keywords, string metainfo, int idConf, List<int> authorIds, List<int> topicIds)
        {
            try
            {
                int idPaper = this.repository.uploadAbstractPaper(name, abstractPaper, keywords, metainfo, idConf);
                authorIds.Add(user.Id);
                this.repository.linkAuthorsToAbstractPaper(authorIds, idPaper);
                this.repository.linkTopicsToAbstractPaper(topicIds, idPaper);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void uploadNewPaperVersion(string name, string newAbstract)
        {
            try
            {
                this.repository.uploadNewAbstractVersion(name, newAbstract);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<BidProposal> getBidProposalsForPaper(string id_paper)
        {
            try
            {
                return this.repository.getBidProposalsByPaper(id_paper);
            }
            catch(RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void bidProposal(User user, AbstractPaper abstractPaper, Verdict selectedVerdict)
        {
            try
            {
                this.repository.bidProposal(user, abstractPaper, selectedVerdict);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
        Get the verdict for a proposal given by a reviewer in case there is one, null otherwise
        Input: user - the reviewer
               abstractPaper - the paper to be checked for
        Output: the verdict if there is one, null otherwise
         */
        public Verdict getVerdictForProposalByReviewer(User user, AbstractPaper abstractPaper)
        {
            try
            {
                List<BidProposal> bidProposals = repository.getBidProposalsByUser(user);
                BidProposal foundProposal = bidProposals.Find(bid => bid.getIdProposal() == abstractPaper.Id);
                if(foundProposal == null)
                {
                    return null;
                }
                return repository.getVerdictById(foundProposal.getIdVerdict());
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<Verdict> getVerdicts()
        {
            try
            {
                return this.repository.getVerdicts();
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public bool abstractHasPaper(int idAbstract)
        {
            try
            {
                return this.repository.abstractHasPaper(idAbstract);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<Review> getReviews()
        {
            try
            {
                return this.repository.getReviews();
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public AbstractPaper getAbstractForId(int abstractId)
        {
            try
            {
                return this.repository.getAbstractForId(abstractId);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<int> getTopicsForAbstract(int abstractId)
        {
            try
            {
                return this.repository.getTopicsForAbstract(abstractId);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<AbstractPaper> getAbstractsWithoutPresentationForConference(int idConference)
        {
            List<AbstractPaper> abstracts = this.getAbstractsForConference(idConference);
            abstracts = abstracts.FindAll(abstr =>
            {
                return !this.repository.abstractHasPresentation(abstr.Id);
            });
            return abstracts;
        }
    }
}
