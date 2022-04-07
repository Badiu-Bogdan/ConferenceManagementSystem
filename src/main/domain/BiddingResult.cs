using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class BiddingResult
    {
        private int id;

        private string resBid;
        private DateTime biddingDate;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string ResBid
        {
            get { return resBid; }
            set { resBid = value; }
        }

        public DateTime BiddingDate
        {
            get { return biddingDate; }
            set { biddingDate = value; }
        }
    }
}
