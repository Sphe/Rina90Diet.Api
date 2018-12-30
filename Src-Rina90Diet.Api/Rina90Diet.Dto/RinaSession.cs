using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class RinaSession
    {

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<RinaDay> DaysListed { get; set; }

    }
}
