using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgEgenskab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Trekant trekant = new Trekant(5.5, 4.4);
            Console.WriteLine("Grundlinjen er: "+trekant.Grundlinje);
            Console.WriteLine("Højde er: "+trekant.Højde);
            Console.WriteLine("Arealet er: "+trekant.Areal);
            Console.ReadKey();
        }

        public class Trekant
        {

            private double grundLinje;
            private double højde;
            private double areal;

            public double Areal
            {


                get {
                    areal = Højde * Grundlinje * 0.5;
                    return areal; }
                
            }


            public Trekant(double højde, double grundlinje)
            {
                Højde = højde;
                Grundlinje = grundlinje;
            }

            public double Højde
            {
                get { return højde; }
                private set { højde = value; }
            }


            public double Grundlinje
            {
                get { return grundLinje; }
                private set { grundLinje = value; }
            }

        }
    }
}
