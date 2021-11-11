using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Logger
{
    class ConsoleLogger : ILogger
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(DateTime.Now + " INFO: " + message);
        }
    }
}
