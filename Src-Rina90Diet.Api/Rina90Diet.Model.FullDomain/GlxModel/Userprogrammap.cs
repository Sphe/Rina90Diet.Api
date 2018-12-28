using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Userprogrammap
    {
        public int Userprogramid { get; set; }
        public int Userid { get; set; }
        public bool Activate { get; set; }
        public bool Termaccepted { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public User User { get; set; }
    }
}
