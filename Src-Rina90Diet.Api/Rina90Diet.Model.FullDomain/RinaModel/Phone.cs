using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Phone : BaseEntity
    {
        public int Phoneid { get; set; }
        public int Phonetypeid { get; set; }
        public int Peopleid { get; set; }
        public string Phone1 { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public string Note { get; set; }

        public People People { get; set; }
        public Phonetype Phonetype { get; set; }
    }
}
