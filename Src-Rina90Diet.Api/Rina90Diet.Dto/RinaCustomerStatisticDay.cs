using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class RinaCustomerStatisticDay
    {

        public int IndexDay { get; set; }

        public DateTime TimeStamp { get; set; }



        public decimal? WeightInKg { get; set; }

        
        public decimal TheoricWeightInKg { get; set; }

        //public decimal TheoricLossPercentFromStart { get; set; }

        //public decimal TheoricLossPercentFromLastDay { get; set; }

            
        //public decimal? RealLossPercentFromStart { get; set; }

        //public decimal? RealLossPercentFromLastDay { get; set; }

        public decimal? CurrentRealLossDifference { get; set; }

        public string CurrentRatingInString { get; set; }
    }
}
