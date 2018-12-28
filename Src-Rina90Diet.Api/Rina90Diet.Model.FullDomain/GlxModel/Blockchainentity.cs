using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Blockchainentity
    {
        public Blockchainentity()
        {
            Coin = new HashSet<Coin>();
            Userblockchainaddress = new HashSet<Userblockchainaddress>();
        }

        public int Blockchainentityid { get; set; }
        public string Blockchainname { get; set; }
        public bool Isdefault { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Coin> Coin { get; set; }
        public ICollection<Userblockchainaddress> Userblockchainaddress { get; set; }
    }
}
