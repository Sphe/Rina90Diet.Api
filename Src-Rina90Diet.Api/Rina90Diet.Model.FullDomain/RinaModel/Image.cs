using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Image
    {
        public Image()
        {
            Articleimagemap = new HashSet<Articleimagemap>();
            Categoryimagemap = new HashSet<Categoryimagemap>();
            Pageimagemap = new HashSet<Pageimagemap>();
        }

        public int Imageid { get; set; }
        public string Thumburl { get; set; }
        public string Fullimageurl { get; set; }
        public bool Active { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Articleimagemap> Articleimagemap { get; set; }
        public ICollection<Categoryimagemap> Categoryimagemap { get; set; }
        public ICollection<Pageimagemap> Pageimagemap { get; set; }
    }
}
