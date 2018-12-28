using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class CoinWalletDto : GenericDto
    {
        public int Coinwalletid { get; set; }

        public int Userblockchainaddressid { get; set; }

        public int Userid { get; set; }
        public int Coinid { get; set; }
        public decimal? Coinaccountbalanceamount { get; set; }
        public decimal? Totalcredit { get; set; }
        public decimal? Totaldebit { get; set; }
        public bool Activate { get; set; }

        
    }
}
