﻿using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Pagebehavior
    {
        public Pagebehavior()
        {
            Pageevent = new HashSet<Pageevent>();
        }

        public int Pagebehaviorid { get; set; }
        public string Description { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Pageevent> Pageevent { get; set; }
    }
}
