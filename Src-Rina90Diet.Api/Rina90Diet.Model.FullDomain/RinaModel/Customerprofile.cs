using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Customerprofile : BaseEntity
    {
        public Customerprofile()
        {
            Customerweightentry = new HashSet<Customerweightentry>();
        }

        public int Customerprofileid { get; set; }
        public int Userid { get; set; }
        public int Numberdietdays { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Heightinm { get; set; }
        public decimal Initialweight { get; set; }
        public decimal Currentweight { get; set; }
        public decimal Targetweight { get; set; }
        public decimal Initialimc { get; set; }
        public decimal Currentimc { get; set; }
        public decimal Targetimc { get; set; }

        public bool Iswaterday { get; set; }

        public User User { get; set; }
        public ICollection<Customerweightentry> Customerweightentry { get; set; }
    }
}
