﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Model.FullDomain
{
    public class BaseEntity
    {
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }
    }
}
