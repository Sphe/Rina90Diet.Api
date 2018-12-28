using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rina90Diet.Common.Core
{
    public class PostconditionException : Exception
    {
        public PostconditionException(string message) : base(message)
        {
        }

        public PostconditionException(string message, Exception inner)
            : base(message, inner)
        {
        } 
    }
}
