using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine();
                for (int x = 1; x < 11; x++)
                {
                    String tal = (x * i).ToString();
                    if ((x*i) > 55)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    } else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(tal.PadLeft(4));
                }
            }
            

            // Your code here.....




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
