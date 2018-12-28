using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Coinwallet : BaseEntity
    {
        public Coinwallet()
        {
            Coinledgercoinwalletmap = new HashSet<Coinledgercoinwalletmap>();
        }

        public int Coinwalletid { get; set; }
        public int Userid { get; set; }
        public int Coinid { get; set; }
        public decimal? Coinaccountbalanceamount { get; set; }
        public decimal? Totalcredit { get; set; }
        public decimal? Totaldebit { get; set; }
        public bool Activate { get; set; }

        public int Userblockchainaddressid { get; set; }

        public Coin Coin { get; set; }
        public User User { get; set; }
        public ICollection<Coinledgercoinwalletmap> Coinledgercoinwalletmap { get; set; }
    }
}
