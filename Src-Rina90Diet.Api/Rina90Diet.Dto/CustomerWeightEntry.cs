using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class CustomerWeightEntry : GenericDto
    {
        public string CustomerProfileId { get; set; }

        public string CustomerWeightEntryId { get; set; }

        public int IndexDay { get; set; }

        public decimal WeightInKg { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
