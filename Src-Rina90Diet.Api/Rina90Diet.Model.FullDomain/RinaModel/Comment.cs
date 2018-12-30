using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Comment
    {
        public int Commentid { get; set; }
        public int Articleid { get; set; }
        public int Userid { get; set; }
        public char Body { get; set; }
        public bool Activate { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Article Article { get; set; }
        public User User { get; set; }
    }
}
