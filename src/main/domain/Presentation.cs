using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class Presentation
    {
        private string id;

        private string title;
        private byte[] presentation;
        private string format;
        private int idAbstract;

        public Presentation(string title, byte[] presentation, string format, int idAbstract)
        {
            this.title = title;
            this.presentation = presentation;
            this.format = format;
            this.idAbstract = idAbstract;
        }

        public Presentation(string id, string title, byte[] presentation, string format, int idAbstract)
        {
            this.id = id;
            this.title = title;
            this.presentation = presentation;
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

        public byte[] getPresentation()
        {
            return this.presentation;
        }

        public void setPresentation(byte[] presentation)
        {
            this.presentation = presentation;
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
