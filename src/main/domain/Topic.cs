using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Topic
    {

        private int id;

        private string name;

        public Topic()
        {

        }

        public Topic(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        // Getters and Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
