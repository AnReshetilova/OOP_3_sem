using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            RAMDiscInfo.GetDriverFreeSpace(@"C:\");
            RAMDiscInfo.GetFileSystemInfo(@"C:\");
            RAMDiscInfo.EveryDriveInfo();
            Console.WriteLine();

            RAMFileInfo.GetFileInfo(@"D:\вуз\3 сем\OOP_3_sem\lab13\ramlogfile.txt");
            Console.WriteLine();

            RAMDirInfo.GetDirInfo(@"D:\вуз\3 сем\OOP_3_sem\lab13");

            RAMFileManager.FilesAndFolders(@"D:\");
            RAMFileManager.MoveFiles();
            RAMFileManager.MakeArchive();

            RAMLog.GetInfo("driver");
            RAMLog.GetLength();
            RAMLog.RemoveOldInfo();
        }
    }
}
