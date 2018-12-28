using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Coinledgercoinwalletmap
    {
        public int Coinledgercoinwalletmapid { get; set; }
        public int? Coinwalletid { get; set; }
        public int? Coinledgerid { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Coinledger Coinledger { get; set; }
        public Coinwallet Coinwallet { get; set; }
    }
}
