using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab13
{
    static class RAMDiscInfo
    {
        public static void GetDriverFreeSpace(string driverName)
        {
            var driver = DriveInfo.GetDrives().Where(m => m.Name == driverName).First();
            Console.WriteLine(driver.AvailableFreeSpace);
            RAMLog.AddInfo("Get driver free space");
        }

        public static void GetFileSystemInfo(string driverName)
        {
            var driver = DriveInfo.GetDrives().Where(m => m.Name == driverName).First();
            Console.WriteLine($"Type: {driver.DriveType}\nFormat: {driver.DriveFormat}");
            RAMLog.AddInfo("Get file system info");
        }

        public static void EveryDriveInfo()
        {
            foreach(var driver in DriveInfo.GetDrives())
            {
                Console.WriteLine($"Name: {driver.Name}\nSize: {driver.TotalSize}\nFree Space: {driver.AvailableFreeSpace}\nVolume Lable: {driver.VolumeLabel}");
            }
            RAMLog.AddInfo("Get every driver info");
        }

    }
}
