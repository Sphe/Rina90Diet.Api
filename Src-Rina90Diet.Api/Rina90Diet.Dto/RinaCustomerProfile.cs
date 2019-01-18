using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class RinaCustomerProfile : GenericDto
    {
        public string CustomerProfileId { get; set; }

        public string CustomerId { get; set; }



        public int TotalDietDays { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public decimal HeightInM { get; set; }


        public decimal InitialWeight { get; set; }

        public decimal CurrentWeight { get; set; }

        public decimal TargetWeight { get; set; }



        public decimal InitialImc { get; set; }

        public decimal CurrentImc { get; set; }

        public decimal TargetImc { get; set; }

        public bool? IsWaterDay { get; set; }

        public bool? Activated { get; set; }

        public List<CustomerWeightEntry> EntryHistoryList { get; set; }

        public RinaSession AssociatedSession { get; set; }
    }
}
