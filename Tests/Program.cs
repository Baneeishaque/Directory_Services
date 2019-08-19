using System;
using System.IO;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dirinfo = new DirectoryInfo(@"C:\Libary_Manager");
            //var entries = dirinfo.GetFileSystemInfos("*.*", SearchOption.AllDirectories)
            //    .Select(t => string.Format("{0}::{1}", t.FullName, t.LastWriteTime.ToString()));

            //Directory.GetFiles(@"C:\Libary_Manager", "*", SearchOption.AllDirectories)
            //    .ToList()
            //    .ForEach(Console.WriteLine);


            //var dirinfo = new DirectoryInfo(@"C:\Libary_Manager");
            //foreach (var f in dirinfo.EnumerateFiles("*", SearchOption.AllDirectories))
            //{
            //    Console.WriteLine(f.FullName + " " + f.LastWriteTime.ToString());
            //}

            //var dir1 = new DirectoryInfo(@"C:\Libary_Manager");

            //try
            //{
            //    foreach (var f in dir1.EnumerateFileSystemInfos("*", SearchOption.AllDirectories))
            //    {
            //        Console.WriteLine(f.FullName + " " + f.LastWriteTime.ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            var fileSystemEnumerator = new FileSystemInfoEnumerator(@"C:\",
                searchOption: SearchOption.AllDirectories,
                errorHandler: Console.WriteLine);

            foreach (var f in fileSystemEnumerator)
            {
                Console.WriteLine(f.FullName + " " + f.LastWriteTime.ToString());
            }

            Console.ReadKey();
        }
    }
}
