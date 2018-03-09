using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] test = { 10800, 71100, 60000, 33000, 100000, 50000, 32000 };
            int sum = 0;

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);

                sum += test[i];
            }
            
            Console.WriteLine("Gennemsnit: " + (sum / test.Length));



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
