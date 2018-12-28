using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Bankaccountverificationstatus
    {
        public Bankaccountverificationstatus()
        {
            Bankdetail = new HashSet<Bankdetail>();
        }

        public int Bankaccountverificationstatusid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Bankdetail> Bankdetail { get; set; }
    }
}
