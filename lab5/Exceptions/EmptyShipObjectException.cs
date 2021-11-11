using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Exceptions
{
    class EmptyShipObjectException : Exception
    {
        const string message = "This ship is empty";

        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
    }
}
