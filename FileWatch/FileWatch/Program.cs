using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher fileSystemWatcher = new System.IO.FileSystemWatcher(@"C:\temp","*.txt");
            fileSystemWatcher.EnableRaisingEvents = true;
            fileSystemWatcher.Changed += FileSystemWatcher_Changed;
            fileSystemWatcher.Created += FileSystemWatcher_Created;
            //Denne er lavet på hurtigere måde
            fileSystemWatcher.Deleted += (s, e) => { Console.WriteLine("Slettet " + "" + e.FullPath); };


            do
            {

            } while (true);
          

                 
        }

       

        private static void FileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen er oprettet: " + DateTime.Now.ToLongTimeString() + "" + e.FullPath);
        }

        private static void FileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen er ændret: "+DateTime.Now.ToLongTimeString()+""+e.FullPath);
        }
    }
}
