using System;

namespace Opg01Variabler
{
    class Program
    {
        static void Main(string[] args)
        {


            int heltal = 10;
            heltal++;
            Console.WriteLine("" + heltal);
            heltal--;
            Console.WriteLine("" + heltal);
            heltal += 20;
            Console.WriteLine("" + heltal);

            double kommatal = 12.5;
            kommatal++;
            Console.WriteLine("" + kommatal);
            kommatal--;
            Console.WriteLine("" + kommatal);
            kommatal *= 2;
            Console.WriteLine("" + kommatal);

            Filtyper ft = Filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine(Convert.ToInt16(ft));

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("ddMMyy"));

            Person p;
            p.id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {


                //RR
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            
        }

        public enum Filtyper
        {
            csv,
            pdf,
            txt,
        }

        struct Person
        {
            public int id;
            public String Navn;
        }
    }

}
