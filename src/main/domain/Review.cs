using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Review
    {
        private int id;
        private string verdict;
        private int points;

        public Review(string verdict, int points)
        {
            this.verdict = verdict;
            this.points = points;
        }

        public Review(int id, string verdict, int points)
        {
            this.id = id;
            this.verdict = verdict;
            this.points = points;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Verdict
        {
            get { return verdict; }
            set { verdict = value; }
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }


    }
}
