using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Coin
    {
        public Coin()
        {
            Allowancesheet = new HashSet<Allowancesheet>();
            Balancesheet = new HashSet<Balancesheet>();
            Coingenericattributemap = new HashSet<Coingenericattributemap>();
            Coinledger = new HashSet<Coinledger>();
            Coinwallet = new HashSet<Coinwallet>();
            Order = new HashSet<Order>();
            Registrysheet = new HashSet<Registrysheet>();
        }

        public int Coinid { get; set; }
        public int? Blockchainentityid { get; set; }
        public string Coinname { get; set; }
        public string Coinlabel { get; set; }
        public string Coinsymbol { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Blockchainentity Blockchainentity { get; set; }
        public ICollection<Allowancesheet> Allowancesheet { get; set; }
        public ICollection<Balancesheet> Balancesheet { get; set; }
        public ICollection<Coingenericattributemap> Coingenericattributemap { get; set; }
        public ICollection<Coinledger> Coinledger { get; set; }
        public ICollection<Coinwallet> Coinwallet { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Registrysheet> Registrysheet { get; set; }
    }
}
