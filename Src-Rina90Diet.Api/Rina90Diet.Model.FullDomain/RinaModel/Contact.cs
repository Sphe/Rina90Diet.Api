using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Contact
    {
        public int Contactid { get; set; }
        public int Contacttypeid { get; set; }
        public int? Peopleid { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Contacttype Contacttype { get; set; }
        public People People { get; set; }
    }
}
