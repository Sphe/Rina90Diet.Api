using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Registrysheetattributemap
    {
        public int Registrysheetgenericattributeid { get; set; }
        public int? Genericattributeid { get; set; }
        public int? Registrysheetid { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Genericattribute Genericattribute { get; set; }
        public Registrysheet Registrysheet { get; set; }
    }
}
