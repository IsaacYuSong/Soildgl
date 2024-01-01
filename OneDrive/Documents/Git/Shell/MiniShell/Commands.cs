using System;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml;

namespace MiniShell
{
    public class Commands
    {
        public static void Cd(string? newDirectoryPath = null)
        {

            if (string.IsNullOrEmpty(newDirectoryPath) || newDirectoryPath.Trim() == "")
            {
                newDirectoryPath = Directory.GetCurrentDirectory();

            }
            DirectoryInfo directoryInfo = new DirectoryInfo(newDirectoryPath);
            if (directoryInfo.Exists)
            {
                Directory.SetCurrentDirectory(newDirectoryPath);

            }
            else
            {
                Console.WriteLine("Directory " + newDirectoryPath + " does not exist.");
            }
        }


        public static void Dir(string currentDirectory = null)
        {
            currentDirectory = currentDirectory ?? Directory.GetCurrentDirectory();
            var files = Directory.GetFiles(currentDirectory);
            var directories = Directory.GetDirectories(currentDirectory);

            Console.WriteLine("Directories:");
            foreach (var dir in directories)
            {
                Console.WriteLine($"  {Path.GetFileName(dir)}");
            }

            Console.WriteLine("\nFiles:");
            foreach (var file in files)
            {
                Console.WriteLine($"  {Path.GetFileName(file)}");
            }
        }

        public static void WhoAmI()
        {
            string userName = Environment.UserName;
            Console.WriteLine(userName);
        }
    }
}
