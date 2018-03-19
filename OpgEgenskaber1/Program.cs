using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgEgenskaber1
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare { Navn = "Pepsi Max", Pris = 5.5 };
            Console.WriteLine("Prisen på vare: "+v.Pris);
            Console.WriteLine("Navn på vare "+v.Navn);
            Console.WriteLine("Pris med moms"+v.PrisMedMoms());
            Console.ReadKey();
        }

        public class Vare
        {
            private string navn;
            private double pris;

            public Vare()
            {

            }

            public Vare(string navn, double pris)
            {
                Navn = navn;
                Pris = pris;
            }


            public string Navn
            {
                get {

                    Console.WriteLine("Navn er Read");
                    return navn; }
                set {
                    Console.WriteLine("Navn er set");
                    navn = value; }
            }


           

          

            public double Pris
            {
                get {
                    Console.WriteLine("Pris er hentet");
                    return pris; }
                set {
                    Console.WriteLine("Pris er sat");
                    pris = value; }
            }

            public double PrisMedMoms()
            {
                double prisMedMoms = Pris * 1.25;
                return prisMedMoms;
            }

        }
    }
}
