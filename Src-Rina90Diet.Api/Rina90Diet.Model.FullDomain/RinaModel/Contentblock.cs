﻿using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Contentblock : BaseEntity
    {
        public Contentblock()
        {
            Contentblockculturemap = new HashSet<Contentblockculturemap>();
        }

        public int Contentblockid { get; set; }
        public int? Contentblocktypeid { get; set; }
        public int? Pageid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Activate { get; set; }
        public int? Sort { get; set; }

        public Contentblocktype Contentblocktype { get; set; }
        public Page Page { get; set; }
        public ICollection<Contentblockculturemap> Contentblockculturemap { get; set; }
    }
}
