using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class People
    {
        public People()
        {
            Contact = new HashSet<Contact>();
            Peoplemacaddress = new HashSet<Peoplemacaddress>();
            Phone = new HashSet<Phone>();
            User = new HashSet<User>();
        }

        public int Peopleid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Lastip { get; set; }


        public DateTime? Dateofbirth { get; set; }

        public string Nationality { get; set; }

        public string Addressline1 { get; set; }

        public string Addressline2 { get; set; }

        public string City { get; set; }

        public string Zipcode { get; set; }

        public string Country { get; set; }

        public string Phonenumber { get; set; }

        public string Telegramuser { get; set; }


        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Contact> Contact { get; set; }
        public ICollection<Peoplemacaddress> Peoplemacaddress { get; set; }
        public ICollection<Phone> Phone { get; set; }
        public ICollection<User> User { get; set; }
    }
}
