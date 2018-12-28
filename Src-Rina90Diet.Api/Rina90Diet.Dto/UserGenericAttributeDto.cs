using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class UserGenericAttributeDto : GenericDto
    {
        public int Userattributeid { get; set; }
        public int? Genericattributeid { get; set; }
        public int? Userid { get; set; }
        public bool? Active { get; set; }

        public GenericAttributeDto Genericattribute { get; set; }

    }
}
