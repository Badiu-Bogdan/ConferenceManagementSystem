using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Section
    {
        private int id;

        private string topic;
        List<int> idAbstracts;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public List<int> IdAbstracts
        {
            get { return idAbstracts; }
            set { idAbstracts = value; }
        }
    }
}
