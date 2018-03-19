using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirekant(10,10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
            Console.ReadKey();
        }

        static class ArealBeregninger
        {

            public static double BeregnArealFirekant(double h, double b)
            {
                return h * b;
            }

            public static double BeregnArealCirkel(double r)
            {
                return System.Math.Pow(2, r)*Math.PI;
            }
        }
    }
}
