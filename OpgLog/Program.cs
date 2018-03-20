using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgLog
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("kalder Test1");
            test1(5, 5);
            logger.Trace("kalder Test2");
            test2();
        }
        static void test1(int i, int x)
        {
            logger.Trace("Test1 startet");
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            logger.Trace("Test1 slut");
        }

        static void test2()
        {
            try
            {
                logger.Trace("starter Test2");
                Console.WriteLine("test2");
                throw new ApplicationException("Fejl");
            }
            catch (Exception)
            {

                logger.Error("test2 fejler");
            }
        }
    }
}
