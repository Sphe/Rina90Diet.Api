using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Genericattribute
    {
        public Genericattribute()
        {
            Coingenericattributemap = new HashSet<Coingenericattributemap>();
            Registrysheetattributemap = new HashSet<Registrysheetattributemap>();
            Usergenericattributemap = new HashSet<Usergenericattributemap>();
            Workflowgenericattributemap = new HashSet<Workflowgenericattributemap>();
        }

        public int Genericattributeid { get; set; }
        public int? Genericattributetypeid { get; set; }
        public int? Genericattributevalueid { get; set; }
        public string Typestring { get; set; }
        public string Typelabelstring { get; set; }
        public string Valuestring { get; set; }
        public string Valuelabelstring { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Genericattributetype Genericattributetype { get; set; }
        public Genericattributevalue Genericattributevalue { get; set; }
        public ICollection<Coingenericattributemap> Coingenericattributemap { get; set; }
        public ICollection<Registrysheetattributemap> Registrysheetattributemap { get; set; }
        public ICollection<Usergenericattributemap> Usergenericattributemap { get; set; }
        public ICollection<Workflowgenericattributemap> Workflowgenericattributemap { get; set; }
    }
}
