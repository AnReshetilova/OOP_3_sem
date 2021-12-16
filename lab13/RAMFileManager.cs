using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace lab13
{
    static class RAMFileManager
    {
        public static void FilesAndFolders(string path)
        {
            DirectoryInfo driver = new DirectoryInfo(path);
            DirectoryInfo dir = new DirectoryInfo(@"D:\вуз\3 сем\OOP_3_sem\lab13");
            dir.CreateSubdirectory(@"RAMInspect");
            using (StreamWriter sw = new StreamWriter(@"D:\вуз\3 сем\OOP_3_sem\lab13\RAMInspect\ramdirinfo.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine("DIRECTORIES");
                foreach(var directory in driver.GetDirectories())
                {
                    sw.WriteLine(directory.Name);
                }
                sw.WriteLine("FILES");
                foreach (var file in driver.GetFiles())
                {
                    sw.WriteLine(file.Name);
                }
            }

            File.Copy(@"D:\вуз\3 сем\OOP_3_sem\lab13\RAMInspect\ramdirinfo.txt", @"D:\вуз\3 сем\OOP_3_sem\lab13\RAMInspect\ramCopydirinfo.txt", true);
            File.Delete(@"D:\вуз\3 сем\OOP_3_sem\lab13\RAMInspect\ramdirinfo.txt");

            RAMLog.AddInfo("Get files and folders");
        }

        public static void MoveFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\вуз\3 сем\OOP_3_sem\lab13");
            dir.CreateSubdirectory("RAMFiles");

            foreach (var file in new DirectoryInfo(@"D:\вуз\3 сем\Книги ЭВМ").GetFiles().Where(m => m.Extension == ".docx"))
            {
                file.CopyTo(@"D:\вуз\3 сем\OOP_3_sem\lab13\RAMFiles\" + file.Name);
            }

            Directory.Move(@"D:\вуз\3 сем\OOP_3_sem\lab13\RAMFiles", @"D:\вуз\3 сем\OOP_3_sem\lab13\RAMInspect\RAMFiles");

            RAMLog.AddInfo("files are moved");
        }

        public static void MakeArchive()
        {
            ZipFile.CreateFromDirectory(@"D:\вуз\3 сем\OOP_3_sem\lab13\RAMInspect", @"D:\вуз\3 сем\OOP_3_sem\lab13\RAMInspect.zip");

            RAMLog.AddInfo("files are archived");
        }
    }
}
