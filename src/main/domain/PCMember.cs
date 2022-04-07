using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.domain
{
    public class PCMember : User 
    {
        public PCMember(int id, string firstName, string lastName, string email, string username, string password, DateTime dob, string address, string affiliation, string website) :
            base(id, firstName, lastName, email, username, password, dob, address, affiliation, website)
        {
            
        }
    }
}
