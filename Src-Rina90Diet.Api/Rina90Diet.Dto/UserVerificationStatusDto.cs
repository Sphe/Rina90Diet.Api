using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class UserVerificationStatusDto : GenericDto
    {
        public int Userverificationstatusid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
