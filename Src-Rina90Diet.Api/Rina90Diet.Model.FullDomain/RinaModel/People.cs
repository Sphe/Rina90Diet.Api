using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class People : BaseEntity
    {
        public People()
        {
            Contact = new HashSet<Contact>();
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

        public ICollection<Contact> Contact { get; set; }
        public ICollection<Phone> Phone { get; set; }
        public ICollection<User> User { get; set; }
    }
}
