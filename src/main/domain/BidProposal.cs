
namespace ConferenceManagementSystem.src.main.domain
{
    public class BidProposal
    {

        private int id;

        private int idReviewer;
        private int idProposal;
        private int idVerdict;

        public BidProposal(int idReviewer, int idProposal, int idVerdict)
        {
            this.idReviewer = idReviewer;
            this.idProposal = idProposal;
            this.idVerdict = idVerdict;
        }

        public BidProposal(int id, int idReviewer, int idProposal, int idVerdict)
        {
            this.id = id;
            this.idReviewer = idReviewer;
            this.idProposal = idProposal;
            this.idVerdict = idVerdict;
        }

        // Getters and Setters
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setIdReviewer(int idReviewer)
        {
            this.idReviewer = idReviewer;
        }

        public int getIdReviewer()
        {
            return this.idReviewer;
        }

        public int getIdProposal()
        {
            return this.idProposal;
        }

        public void setIdProposal(int idProposal)
        {
            this.idProposal = idProposal;
        }

        public int getIdVerdict()
        {
            return this.idVerdict;
        }

        public void setIdVerdict(int idVerdict)
        {
            this.idVerdict = idVerdict;
        }
    }

}
