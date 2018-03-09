using System;
using System.Linq;
namespace OppSmaMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            Udskriv("detter er en test");
            int[] løn = { 10000, 5000, 30000};
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);
            




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static int LægSammen ( int a, int b)
        {
           int sum= a + b;
            return sum;

        }

        static double BeregnAreal (int radius)
        {
            double resultat = radius * radius * System.Math.PI;
            return resultat;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
            
        }

        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }

            double gns = sum /månedsløn.Length;
            return gns;
        }
    }
}
