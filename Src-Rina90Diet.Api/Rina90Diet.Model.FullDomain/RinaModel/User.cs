using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class User : BaseEntity
    {
        public User()
        {
            Article = new HashSet<Article>();
            CommentNavigation = new HashSet<Comment>();
            Customerprofile = new HashSet<Customerprofile>();
            Pageevent = new HashSet<Pageevent>();
            Usergenericattributemap = new HashSet<Usergenericattributemap>();
        }

        public int Userid { get; set; }
        public int? Cultureid { get; set; }
        public int? Encryptionid { get; set; }
        public int Peopleid { get; set; }
        public int? Userverificationstatusid { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Taxexempt { get; set; }
        public DateTime? Lastlogindate { get; set; }
        public DateTime? Lastactivitydate { get; set; }
        public DateTime? Lastpasswordchangeddate { get; set; }
        public DateTime? Lastlockoutdate { get; set; }
        public char? Passwordhint { get; set; }
        public char? Comment { get; set; }
        public char? Passwordanswer { get; set; }
        public int? Locked { get; set; }
        public DateTime? Lockeduntil { get; set; }
        public int? Failedlogincount { get; set; }
        public int? Failedanswercount { get; set; }
        public bool Activate { get; set; }
        public string Personalreference { get; set; }

        public Culture Culture { get; set; }
        public People People { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<Comment> CommentNavigation { get; set; }
        public ICollection<Customerprofile> Customerprofile { get; set; }
        public ICollection<Pageevent> Pageevent { get; set; }
        public ICollection<Usergenericattributemap> Usergenericattributemap { get; set; }
    }
}
