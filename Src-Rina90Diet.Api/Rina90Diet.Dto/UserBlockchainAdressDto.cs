using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class UserBlockchainAdressDto : GenericDto
    {
        public int Userblockchainaddressid { get; set; }
        public int? Userid { get; set; }
        public int? Blockchainentityid { get; set; }
        public string Blockchainpublicaddress { get; set; }
        public string Blockchainprivatekey { get; set; }
        public bool? Isdefault { get; set; }
        public bool? Active { get; set; }

        public string Walletname { get; set; }

    }
}
