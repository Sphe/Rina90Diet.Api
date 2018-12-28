using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Transactionstatus
    {
        public Transactionstatus()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Transactionstatusid { get; set; }
        public string Status { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Transaction> Transaction { get; set; }
    }
}
