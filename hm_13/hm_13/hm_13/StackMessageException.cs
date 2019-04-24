using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_13
{
    internal class StackMessageException : Exception
    {
        public StackMessageException()
        {
        }

        public StackMessageException(string message)
            : base (message)
        {
        }
    }
}
