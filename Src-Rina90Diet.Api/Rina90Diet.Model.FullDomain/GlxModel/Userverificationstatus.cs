using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Userverificationstatus : BaseEntity
    {
        public Userverificationstatus()
        {
            User = new HashSet<User>();
        }

        public int Userverificationstatusid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<User> User { get; set; }
    }
}
