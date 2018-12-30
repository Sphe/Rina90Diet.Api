using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Category
    {
        public Category()
        {
            Categoryculturemap = new HashSet<Categoryculturemap>();
            Categoryimagemap = new HashSet<Categoryimagemap>();
            Genericattributetype = new HashSet<Genericattributetype>();
            InverseParent = new HashSet<Category>();
            Page = new HashSet<Page>();
        }

        public int Categoryid { get; set; }
        public int? Parentid { get; set; }
        public bool Isdefault { get; set; }
        public bool Activate { get; set; }
        public int Sort { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Category Parent { get; set; }
        public ICollection<Categoryculturemap> Categoryculturemap { get; set; }
        public ICollection<Categoryimagemap> Categoryimagemap { get; set; }
        public ICollection<Genericattributetype> Genericattributetype { get; set; }
        public ICollection<Category> InverseParent { get; set; }
        public ICollection<Page> Page { get; set; }
    }
}
