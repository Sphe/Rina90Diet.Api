using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Order
    {
        public Order()
        {
            Coinledger = new HashSet<Coinledger>();
            Orderitem = new HashSet<Orderitem>();
            Ordernote = new HashSet<Ordernote>();
            Transaction = new HashSet<Transaction>();
        }

        public int Orderid { get; set; }
        public int Orderstatusid { get; set; }
        public int? Userid { get; set; }
        public int? Cultureid { get; set; }
        public int? Coinid { get; set; }
        public string Ordernumber { get; set; }
        public decimal Subtotal { get; set; }
        public decimal? Subshippingtotal { get; set; }
        public decimal? Shippingamount { get; set; }
        public decimal? Subweeetotal { get; set; }
        public decimal? Weeeamount { get; set; }
        public decimal Taxamount { get; set; }
        public decimal Grandtotal { get; set; }
        public decimal? Couponamount { get; set; }
        public decimal Finaltotal { get; set; }
        public DateTime? Dateshipped { get; set; }
        public string Trackingnumber { get; set; }
        public DateTime? Estimateddelivery { get; set; }
        public DateTime? Executedon { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Coin Coin { get; set; }
        public Culture Culture { get; set; }
        public Orderstatus Orderstatus { get; set; }
        public User User { get; set; }
        public ICollection<Coinledger> Coinledger { get; set; }
        public ICollection<Orderitem> Orderitem { get; set; }
        public ICollection<Ordernote> Ordernote { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
