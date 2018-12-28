using System;
using System.Collections.Generic;

namespace Rina90Diet.Model.FullDomain
{
    public partial class Culture : BaseEntity
    {
        public Culture()
        {
            Article = new HashSet<Article>();
            Categoryculturemap = new HashSet<Categoryculturemap>();
            Contentblockculturemap = new HashSet<Contentblockculturemap>();
            Order = new HashSet<Order>();
            Pageculturemap = new HashSet<Pageculturemap>();
            Shoppingcart = new HashSet<Shoppingcart>();
            User = new HashSet<User>();
        }

        public int Cultureid { get; set; }
        public string Languagecode { get; set; }
        public string Locale { get; set; }
        public string Defaultcurrencycode { get; set; }
        public string Defaultsizecode { get; set; }
        public string Defaultweightcode { get; set; }
        public string Defaultsizeunit { get; set; }
        public string Defaultweightunit { get; set; }

        public ICollection<Article> Article { get; set; }
        public ICollection<Categoryculturemap> Categoryculturemap { get; set; }
        public ICollection<Contentblockculturemap> Contentblockculturemap { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Pageculturemap> Pageculturemap { get; set; }
        public ICollection<Shoppingcart> Shoppingcart { get; set; }
        public ICollection<User> User { get; set; }
    }
}
