using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class RinaCustomerStatistic
    {

        public List<RinaCustomerStatisticDay> PerDayList { get; set; }

        public RinaCustomerProfile CustomerProfile { get; set; }

    }
}
