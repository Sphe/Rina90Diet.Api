using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Peoplemacaddress
    {
        public int Peoplemacaddressid { get; set; }
        public int? Peopleid { get; set; }
        public string Macaddress { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public People People { get; set; }
    }
}
