using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab13
{
    static class RAMFileInfo
    {
        public static void GetFileInfo(string path)
        {
            FileInfo info = new FileInfo(path);
            if (info.Exists)
            {
                Console.WriteLine($"Path: {info.FullName}");
                Console.WriteLine($"Name: {info.Name}\nSize: {info.Length}\nExtention: {info.Extension}");
                Console.WriteLine($"Creation time: {info.CreationTime}\nLast write time: {info.LastWriteTime}");
                RAMLog.AddInfo("Get file info");
            }
            else
            {
                Console.WriteLine("file doesnt exist");
            }
        }
    }
}
