using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Usergenericattributemap : BaseEntity
    {
        public int Userattributeid { get; set; }
        public int? Genericattributeid { get; set; }
        public int? Userid { get; set; }
        public bool? Active { get; set; }

        public Genericattribute Genericattribute { get; set; }
        public User User { get; set; }
    }
}
