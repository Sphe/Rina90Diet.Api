using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Userblockchainaddress : BaseEntity
    {
        public int Userblockchainaddressid { get; set; }
        public int? Userid { get; set; }
        public int? Blockchainentityid { get; set; }
        public string Blockchainpublicaddress { get; set; }
        public string Blockchainprivatekey { get; set; }
        public bool? Isdefault { get; set; }
        public bool? Active { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public string Walletname { get; set; }

        public Blockchainentity Blockchainentity { get; set; }
        public User User { get; set; }
    }
}
