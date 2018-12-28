using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Balancesheet
    {
        public int Balancesheetid { get; set; }
        public int? Coinid { get; set; }
        public string Blockchainaddress { get; set; }
        public decimal Value { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Coin Coin { get; set; }
    }
}
