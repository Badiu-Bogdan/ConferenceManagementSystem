using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class AbstractPaper
    {
        private int id;
        private string name;
        private string keywords;
        private string metainfo;
        private string abstractpaper;
        private int idConference;
        private string isAccepted;

        public AbstractPaper(int id, string name, string keywords, string metainfo, string abstractpaper, int idConference, string isAccepted)
        {
            this.id = id;
            this.name = name;
            this.keywords = keywords;
            this.metainfo = metainfo;
            this.abstractpaper = abstractpaper;
            this.idConference = idConference;
            this.isAccepted = isAccepted;
        }

        public AbstractPaper(string name, string keywords, string metainfo, string abstractpaper, int idConference, string isAccepted)
        {
            this.name = name;
            this.keywords = keywords;
            this.metainfo = metainfo;
            this.abstractpaper = abstractpaper;
            this.idConference = idConference;
            this.isAccepted = isAccepted;
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
        public string Keywords
        {
            get { return keywords; }
            set { keywords = value; }
        }

        public string Metainfo
        {
            get { return metainfo; }
            set { metainfo = value; }
        }
        public string Abstractpaper
        {
            get { return abstractpaper; }
            set { abstractpaper = value; }
        }
        public int IdConference
        {
            get { return idConference; }
            set { idConference = value; }
        }
        public string IsAccepted
        {
            get { return isAccepted; }
            set { isAccepted = value; }
        }

    }
}