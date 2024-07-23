using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Exceptions
{
    internal class MovieNotFoundException: Exception
    {
        public MovieNotFoundException(string Message):base(Message) { }
       
    }
}
