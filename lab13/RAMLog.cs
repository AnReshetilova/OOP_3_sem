using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab13
{
    static class RAMLog
    {
        const string path = @"D:\вуз\3 сем\OOP_3_sem\lab13\ramlogfile.txt";

        public static void AddInfo(string info)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine($"message: {info}          time: {DateTime.Now}\n");
            }
        }

        public static void GetInfo(string info)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                { 
                    if (str.Contains(info))
                    {
                        Console.WriteLine(str);
                    }
                }
            }
        }

        public static void GetLength()
        {
            FileInfo file = new FileInfo(path);
            Console.WriteLine(path.Length);
        }

        public static void RemoveOldInfo()
        {
            FileInfo file = new FileInfo(path);
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(path).Where(l => l.Contains(DateTime.Now.Hour.ToString()));

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(path);
            File.Move(tempFile, path);
        }
    }
}
