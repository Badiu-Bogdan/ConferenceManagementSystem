using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Message
    {
        private int id;

        private int idSender;
        private string content;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdSender
        {
            get { return idSender; }
            set { idSender = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
