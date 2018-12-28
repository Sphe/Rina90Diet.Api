using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Coinledger
    {
        public Coinledger()
        {
            Coinledgercoinwalletmap = new HashSet<Coinledgercoinwalletmap>();
            Transaction = new HashSet<Transaction>();
        }

        public int Coinledgerid { get; set; }
        public int? Transactiontypeid { get; set; }
        public int? Userid { get; set; }
        public int? Coinid { get; set; }
        public int? Orderid { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Coin Coin { get; set; }
        public Order Order { get; set; }
        public Transcationtype Transactiontype { get; set; }
        public User User { get; set; }
        public ICollection<Coinledgercoinwalletmap> Coinledgercoinwalletmap { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
