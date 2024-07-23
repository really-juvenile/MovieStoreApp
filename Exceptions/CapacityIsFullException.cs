using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Exceptions
{
    internal class CapacityIsFullException : Exception
    {
        public CapacityIsFullException(string Message):base(Message) { }
      
    }
}
