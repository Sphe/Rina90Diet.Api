using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Shoppingcartevent
    {
        public int Shoppingcarteventid { get; set; }
        public int Shoppingcartbehaviorid { get; set; }
        public int? Userid { get; set; }
        public int Shoppingcartid { get; set; }
        public DateTime Eventdate { get; set; }
        public string Oldeventcontent { get; set; }
        public string Eventcontent { get; set; }
        public string Ip { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Shoppingcart Shoppingcart { get; set; }
        public Shoppingcartbehavior Shoppingcartbehavior { get; set; }
        public User User { get; set; }
    }
}
