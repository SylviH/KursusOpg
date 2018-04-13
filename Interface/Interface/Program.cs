using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Ubåd ubåd = new Ubåd();
            ubåd.Gem();

            Hund hund = new Hund();
            hund.Gem();

            IDbFunktioner[] dbFunktioners = new IDbFunktioner[2];

            dbFunktioners[0] = hund;
            dbFunktioners[1] = ubåd;

            foreach (var item in dbFunktioners)
            {
                item.Gem();
            }
        }
    }

    class Hund:IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer"+this.Navn);
            Console.ReadKey();
        }
    }

    class Ubåd:IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer");
        }
    }

    interface IDbFunktioner
    {
       void Gem();
    }
}
