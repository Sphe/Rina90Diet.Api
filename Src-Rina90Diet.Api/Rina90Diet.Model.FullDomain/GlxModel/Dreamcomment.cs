using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Dreamcomment
    {
        public int Commentid { get; set; }
        public int? Userid { get; set; }
        public int? Vote { get; set; }
        public string Content { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public User User { get; set; }
    }
}
