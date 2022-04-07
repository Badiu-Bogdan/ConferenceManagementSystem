using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class UserType
    {
        private int id;

        private string name;
        private string description;

        public UserType(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public UserType(string name, string description)
        {
            this.name = name;
            this.description = description;
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

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string desc)
        {
            this.description = desc;
        }
    }
}
