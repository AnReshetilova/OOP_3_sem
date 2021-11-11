using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab5.Logger
{
    class FileLogger: ILogger
    {
        public void PrintMessage(string message)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\вуз\3 сем\OOP_3_sem\lab5\Logger\log.txt"))
            {
                sw.WriteLine(DateTime.Now + " INFO: " + message);
            }
        }
    }
}
