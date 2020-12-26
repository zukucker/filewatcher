using System;
using System.IO;
using System.Threading;
using System.Security.Permissions;

namespace filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {
          Run();
        }


        //public static void Run()
        //{
          //using (FileSystemWatcher watcher = new FileSystemWatcher())
          //{
            //watcher.Path = ("/home/alex/GIT/filewatcher");
            //watcher.NotifyFilter = NotifyFilters.LastWrite;
              //watcher.Changed += onChanged;

            //watcher.EnableRaisingEvents = true;

            //Console.WriteLine("press q to exit");
            //Console.ReadLine(); 
          //}
        //}

        //private static void onChanged(object source, FileSystemEventArgs e)
        //{

        //}
        public static void Run()
        {
          var inputfile = "/home/alex/GIT/filewatcher/inputfile";
          var lastRead = File.GetLastWriteTime(inputfile);
          var read = true;
          while(read){
            DateTime lastWrite = File.GetLastWriteTime(inputfile);
            if(lastRead != lastWrite){
              Console.WriteLine("File has been changed " + "(" + DateTime.Now + ")" );
              read = false;
              Run();
            }
          }

        }
    }
}
