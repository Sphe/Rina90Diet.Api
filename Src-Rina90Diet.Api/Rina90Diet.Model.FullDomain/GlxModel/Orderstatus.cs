using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Orderstatus
    {
        public Orderstatus()
        {
            Order = new HashSet<Order>();
        }

        public int Orderstatusid { get; set; }
        public string Description { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
