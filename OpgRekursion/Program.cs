using System;

namespace OpgRekursion
{
    class Program
    {
        static void Main(string[] args)
        {


            UdskrivTal(1, 10);




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void UdskrivTal(int Start, int Stop)
        {
            Console.WriteLine(Start);
            if (Start == Stop)
            {
                return;
            }
            Start++;
            UdskrivTal(Start, Stop);
        
        }

    }
}
