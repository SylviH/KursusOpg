using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOpg2
{
    class Program
    {
        //static void AppendLog( string txt)
        //{
        //System.IO.File.AppendAllText(@"C:\temp\log.txt", txt + "\r\n");
        //}
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log += Console.WriteLine;
            m.Log += delegate (string txt) { System.IO.File.AppendAllText(@"C:\temp\log.txt", txt + "\r\n"); };
            m.Start();
            m.Stop();
            Console.ReadKey();
        }
    }
    public delegate void LogDelegate(string txt);
    class Maskine
    {
        public LogDelegate Log { get; set; }

        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + "Starter");
        }

        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + "Stopper");
        }
    }
}
