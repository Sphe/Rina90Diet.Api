using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Orderitem
    {
        public int Orderitemid { get; set; }
        public int Orderid { get; set; }
        public decimal? Discountamount { get; set; }
        public int Quantity { get; set; }
        public decimal? Unitprice { get; set; }
        public decimal? Unittaxprice { get; set; }
        public decimal? Weeeprice { get; set; }
        public decimal? Weeetaxprice { get; set; }
        public decimal? Totalprice { get; set; }
        public decimal? Totaltaxprice { get; set; }
        public decimal? Grandprice { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Order Order { get; set; }
    }
}
