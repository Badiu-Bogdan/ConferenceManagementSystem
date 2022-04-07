
namespace ConferenceManagementSystem.src.main.domain
{
    public class Verdict
    {
        private string id;

        private string verdict;

        public Verdict(string verdict)
        {
            this.verdict = verdict;
        }

        public Verdict(string id, string verdict)
        {
            this.id = id;
            this.verdict = verdict;
        }

        // Getters and Setters
        public string getId()
        {
            return this.id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getVerdict()
        {
            return this.verdict;
        }

        public void setVerdict(string verdict)
        {
            this.verdict = verdict;
        }
    }
}
