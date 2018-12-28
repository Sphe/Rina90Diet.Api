using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rina90Diet.Common.Core
{
    public class AssertionException : Exception
    {
        public AssertionException(string message) : base(message)
        {
        }

        public AssertionException(string message, Exception inner)
            : base(message, inner)
        {
        } 
    }
}
