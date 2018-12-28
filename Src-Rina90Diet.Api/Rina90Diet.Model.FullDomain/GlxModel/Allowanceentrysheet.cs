using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Allowanceentrysheet
    {
        public int Allowanceentrysheetid { get; set; }
        public int? Allowancesheetid { get; set; }
        public string Blockchainaddress { get; set; }
        public decimal? Value { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Allowancesheet Allowancesheet { get; set; }
    }
}
