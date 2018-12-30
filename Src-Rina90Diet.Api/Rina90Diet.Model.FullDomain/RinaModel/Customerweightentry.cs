using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;

namespace Rina90Diet.Front.ApiWeb
{
    public partial class Customerweightentry : BaseEntity
    {
        public int Customerweightentryid { get; set; }
        public int? Customerprofileid { get; set; }
        public decimal Weightinkg { get; set; }
        public int Indexday { get; set; }

        public DateTime Timestamp { get; set; }

        public Customerprofile Customerprofile { get; set; }
    }
}
