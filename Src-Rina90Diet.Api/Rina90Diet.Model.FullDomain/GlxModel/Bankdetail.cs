using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Bankdetail
    {
        public int M { get; set; }
        public int? Userid { get; set; }
        public int? Bankaccountverificationstatusid { get; set; }
        public string Bankname { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string Stateorprovince { get; set; }
        public string Postalcode { get; set; }
        public string Country { get; set; }
        public bool Isdefault { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }
        public string Ibannumber { get; set; }
        public string Switftbicnumber { get; set; }

        public Bankaccountverificationstatus Bankaccountverificationstatus { get; set; }
        public User User { get; set; }
    }
}
