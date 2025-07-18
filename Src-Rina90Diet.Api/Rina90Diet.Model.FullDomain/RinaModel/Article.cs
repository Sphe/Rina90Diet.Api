﻿using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Article : BaseEntity
    {
        public Article()
        {
            Articleimagemap = new HashSet<Articleimagemap>();
            Comment = new HashSet<Comment>();
        }

        public int Articleid { get; set; }
        public int Cultureid { get; set; }
        public int Userid { get; set; }
        public string Title { get; set; }
        public string Metatitle { get; set; }
        public string Metakeyword { get; set; }
        public string Metadescription { get; set; }
        public string Keywords { get; set; }
        public char Body { get; set; }
        public bool? Ishtml { get; set; }
        public bool Activate { get; set; }

        public Culture Culture { get; set; }
        public User User { get; set; }
        public ICollection<Articleimagemap> Articleimagemap { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}
