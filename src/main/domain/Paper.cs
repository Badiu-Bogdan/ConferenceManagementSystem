using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Paper
    {
        private string id;

        private string title;
        private byte[] paper;
        private string format;
        private int idAbstract;

        public Paper(string title, byte[] paper, string format, int idAbstract)
        {
            this.title = title;
            this.paper = paper;
            this.format = format;
            this.idAbstract = idAbstract;
        }

        public Paper(string id, string title, byte[] paper, string format, int idAbstract)
        {
            this.id = id;
            this.title = title;
            this.paper = paper;
            this.format = format;
            this.idAbstract = idAbstract;
        }

        // Getters and Setters
        public string getId()
        {
            return this.id;
        }

        public void setId(string id)
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

        public byte[] getPaper()
        {
            return this.paper;
        }

        public void setPaper(byte[] paper)
        {
            this.paper = paper;
        }

        public string getFormat()
        {
            return this.format;
        }

        public void setFormat(string format)
        {
            this.format = format;
        }

        public int getIdAbstract()
        {
            return this.idAbstract;
        }

        public void setIdAbstract(int idAbstract)
        {
            this.idAbstract = idAbstract;
        }

    }
}
