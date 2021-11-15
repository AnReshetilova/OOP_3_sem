using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.Exceptions
{
    class InconvertableException: Exception
    {
        const string message = "Can't convert to this type";

        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
    }
}
