using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Constantin_Ioan.Entities
{
    [Serializable]
    public class Client
    {
        public long ClientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Ssn { get; set; }
        public Client() { }
        public Client(string lastName, string firstName, string address, string phoneNo, string ssn)
        {
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            PhoneNo = phoneNo;
            Ssn = ssn;
        }
        public Client(long clientId, string lastName, string firstName, string address, string phoneNo, string ssn):this(lastName,firstName,address,phoneNo,ssn)
        {
            ClientId = clientId;
        }

    }
}
