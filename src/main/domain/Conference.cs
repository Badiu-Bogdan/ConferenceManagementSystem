using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Conference
    {
        private int id;

        private string title;
        private string description;
        private DateTime startCFP;
        private DateTime endCFPProp;
        private DateTime endCFPPaper;
        private DateTime startDate;
        private DateTime endDate;
        private List<Topic> topics;
        private int organizerId;
        private bool requiresPaper;

        public Conference(int id, string title, string description, DateTime startCFP, DateTime endCFPProp, DateTime endCFPPaper, DateTime startDate, DateTime endDate, List<Topic> topics, bool requiresPaper)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.startCFP = startCFP;
            this.endCFPProp = endCFPProp;
            this.endCFPPaper = endCFPPaper;
            this.startDate = startDate;
            this.endDate = endDate;
            this.topics = topics;
            this.requiresPaper = requiresPaper;
        }

        public Conference(string title, string description, DateTime startCFP, DateTime endCFPProp, DateTime endCFPPaper, DateTime startDate, DateTime endDate, List<Topic> topics, bool requiresPaper)
        {
            this.title = title;
            this.description = description;
            this.startCFP = startCFP;
            this.endCFPProp = endCFPProp;
            this.endCFPPaper = endCFPPaper;
            this.startDate = startDate;
            this.endDate = endDate;
            this.topics = topics;
            this.requiresPaper = requiresPaper;
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

        public string getTitle()
        {
            return this.title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string desc)
        {
            this.description = desc;
        }

        public DateTime getStartDate()
        {
            return this.startDate;
        }

        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public DateTime getEndDate()
        {
            return this.endDate;
        }

        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }

        public DateTime getStartCFP()
        {
            return this.startCFP;
        }

        public void setStartCFP(DateTime startCFP)
        {
            this.startCFP = startCFP;
        }

        public DateTime getEndCFPProp()
        {
            return this.endCFPProp;
        }

        public void setEndCFPPaper(DateTime endCFPPaper)
        {
            this.endCFPPaper = endCFPPaper;
        }

        public DateTime getEndCFPPaper()
        {
            return this.endCFPPaper;
        }

        public void setEndCFPProp(DateTime endCFPProp)
        {
            this.endCFPProp = endCFPProp;
        }

        public void setTopics(List<Topic> topics)
        {
            this.topics = topics;
        }

        public List<Topic> getTopics()
        {
            return this.topics;
        }

        public void setOrganizerId(int id)
        {
            this.organizerId = id;
        }

        public int getOrganizerId()
        {
            return this.organizerId;
        }

        public void setRequiresPaper(bool req)
        {
            this.requiresPaper = req;
        }

        public bool getRequiresPaper()
        {
            return this.requiresPaper;
        }
    }
}
