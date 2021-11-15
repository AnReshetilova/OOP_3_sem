using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.Exceptions
{
    public class ElementIndexOutOfRangeException : Exception
    {
        const string message = "Ship index out of range";

        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
    }
}
