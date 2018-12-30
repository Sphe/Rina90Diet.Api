using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class RinaDay
    {
        public int DayNumber { get; set; }

        public RinaDayTypeEnum Type { get; set; }

        public DateTime Date { get; set; }

        public string DateString { get; set; }

        public string TypeString { get; set; }


    }
}
