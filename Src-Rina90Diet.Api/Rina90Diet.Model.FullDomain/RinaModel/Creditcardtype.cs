﻿using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Creditcardtype
    {
        public int Creditcardtypeid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }
    }
}
