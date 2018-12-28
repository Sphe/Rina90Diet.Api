using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Coingenericattributemap
    {
        public int Coinattributeid { get; set; }
        public int? Coinid { get; set; }
        public int? Genericattributeid { get; set; }
        public bool? Active { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Coin Coin { get; set; }
        public Genericattribute Genericattribute { get; set; }
    }
}
