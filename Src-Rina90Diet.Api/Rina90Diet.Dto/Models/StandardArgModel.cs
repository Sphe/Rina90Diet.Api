﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto.Models
{
    public class StandardArgModel
    {
        public IList<string> Args { get; set; } 
        public IList<decimal> ArgsDecimal { get; set; }

        public IList<int> ArgsInt { get; set; }

        public IList<DateTime> ArgsDateTime { get; set; }
        public IList<bool> ArgsBool { get; set; }
    }
}
