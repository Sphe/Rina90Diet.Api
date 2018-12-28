using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class User
    {
        public User()
        {
            Abusecommentmap = new HashSet<Abusecommentmap>();
            Article = new HashSet<Article>();
            Bankdetail = new HashSet<Bankdetail>();
            Coinledger = new HashSet<Coinledger>();
            Coinwallet = new HashSet<Coinwallet>();
            CommentNavigation = new HashSet<Comment>();
            Dreamcomment = new HashSet<Dreamcomment>();
            Order = new HashSet<Order>();
            Pageevent = new HashSet<Pageevent>();
            Peopleonline = new HashSet<Peopleonline>();
            Peopleonlinehistory = new HashSet<Peopleonlinehistory>();
            Shoppingcart = new HashSet<Shoppingcart>();
            Shoppingcartevent = new HashSet<Shoppingcartevent>();
            Userblockchainaddress = new HashSet<Userblockchainaddress>();
            Usergenericattributemap = new HashSet<Usergenericattributemap>();
            Userprogrammap = new HashSet<Userprogrammap>();
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
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }
        public string Personalreference { get; set; }

        public Culture Culture { get; set; }
        public Encryptiontype Encryption { get; set; }
        public People People { get; set; }
        public Userverificationstatus Userverificationstatus { get; set; }
        public ICollection<Abusecommentmap> Abusecommentmap { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<Bankdetail> Bankdetail { get; set; }
        public ICollection<Coinledger> Coinledger { get; set; }
        public ICollection<Coinwallet> Coinwallet { get; set; }
        public ICollection<Comment> CommentNavigation { get; set; }
        public ICollection<Dreamcomment> Dreamcomment { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Pageevent> Pageevent { get; set; }
        public ICollection<Peopleonline> Peopleonline { get; set; }
        public ICollection<Peopleonlinehistory> Peopleonlinehistory { get; set; }
        public ICollection<Shoppingcart> Shoppingcart { get; set; }
        public ICollection<Shoppingcartevent> Shoppingcartevent { get; set; }
        public ICollection<Userblockchainaddress> Userblockchainaddress { get; set; }
        public ICollection<Usergenericattributemap> Usergenericattributemap { get; set; }
        public ICollection<Userprogrammap> Userprogrammap { get; set; }
    }
}
