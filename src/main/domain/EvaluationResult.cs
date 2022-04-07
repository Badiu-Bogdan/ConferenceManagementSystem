using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class EvaluationResult
    {

        private int id;

        private string resEv;
        private DateTime evaluationDate;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string ResEv
        {
            get { return resEv; }
            set { resEv = value; }
        }

        public DateTime EvaluationDate
        {
            get { return evaluationDate; }
            set { evaluationDate = value; }
        }
    }
}
