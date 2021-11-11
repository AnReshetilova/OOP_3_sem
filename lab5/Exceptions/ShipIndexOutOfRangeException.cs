using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Exceptions
{
    public class ShipIndexOutOfRangeException : Exception
    {
        const string message = "Ship index out of range";

        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
    }
}
