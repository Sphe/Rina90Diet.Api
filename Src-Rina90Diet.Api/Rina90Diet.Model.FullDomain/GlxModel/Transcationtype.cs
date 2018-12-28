using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Transcationtype
    {
        public Transcationtype()
        {
            Coinledger = new HashSet<Coinledger>();
        }

        public int Transactiontypeid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Coinledger> Coinledger { get; set; }
    }
}
