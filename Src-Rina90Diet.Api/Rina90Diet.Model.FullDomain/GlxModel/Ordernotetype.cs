using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Ordernotetype
    {
        public Ordernotetype()
        {
            Ordernote = new HashSet<Ordernote>();
        }

        public int Ordernotetypeid { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Ordernote> Ordernote { get; set; }
    }
}
