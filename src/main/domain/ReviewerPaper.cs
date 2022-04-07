using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class ReviewerPaper
    {
        private int id;
        private string comment;
        private int idbid;
        private int idreview;
        private DateTime reviewDateTime;

        public ReviewerPaper(int id, string comment, DateTime reviwDateTime, int idbid, int idreview)
        {
            this.id = id;
            this.comment = comment;
            this.idbid = idbid;
            this.idreview = idreview;
            this.reviewDateTime = reviwDateTime;
        }

        // Getters and Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public int Idbid
        {
            get { return idbid; }
            set { idbid = value; }
        }
        public int Idreview
        {
            get { return idreview; }
            set { idreview = value; }
        }

        public DateTime ReviewDateTime
        {
            get { return reviewDateTime; }
            set { reviewDateTime = value; }
        }
    }
}
