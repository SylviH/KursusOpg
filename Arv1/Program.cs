using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Fornavn = "Syliv";
            p.Efternavn = "Hansen";

            Person p1 = new Elev("Gulstue");
            p1.Fornavn = "Hans";
            p1.Efternavn = "Hansen";

            Person p2 = new Instruktør(1234);
            p2.Fornavn = "Johan";
            p2.Efternavn = "Hansen";

            Console.WriteLine(p.Fuldtnavn());
            Console.WriteLine(p1.Fuldtnavn());
            Console.WriteLine(p2.Fuldtnavn());

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string Fuldtnavn()
        {
            return Fornavn + " " + Efternavn; 
        }
    }

    public class Elev : Person
    {
        public Elev(string klasseLokale)
        {
            KlasseLokale = klasseLokale;
        }

        public string KlasseLokale { get; set; }
    }

    public class Instruktør : Person
    {
        public Instruktør(int nøgleId)
        {
            NøgleId = nøgleId;
        }

        public int NøgleId { get; set; }
    }
}
