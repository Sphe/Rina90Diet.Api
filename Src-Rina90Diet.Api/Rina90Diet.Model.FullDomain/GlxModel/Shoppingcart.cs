using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Shoppingcart
    {
        public Shoppingcart()
        {
            Shoppingcartevent = new HashSet<Shoppingcartevent>();
        }

        public int _ { get; set; }
        public string Shoppingcartguid { get; set; }
        public int? Userid { get; set; }
        public int Cultureid { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Taxamount { get; set; }
        public decimal? Grandtotal { get; set; }
        public bool Activate { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Culture Culture { get; set; }
        public User User { get; set; }
        public ICollection<Shoppingcartevent> Shoppingcartevent { get; set; }
    }
}
