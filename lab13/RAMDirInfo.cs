using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab13
{
    static class RAMDirInfo
    {
        public static void GetDirInfo(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine($"Count of files: {dir.GetFiles().Length}");
            Console.WriteLine($"Creation time: {dir.CreationTime}");
            Console.WriteLine($"Count of directries: {dir.GetDirectories().Length}");
            Console.WriteLine($"Parent directory: {dir.Parent}");
            RAMLog.AddInfo("Get directory info");
        }
    }
}
