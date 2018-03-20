using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Elev() { Fornavn = "Sylvi", Efternavn = "Hansen", Klasselokale = "5641" };    
            Person p2 = new Instruktør() { Fornavn = "Hans", Efternavn = "Hansen",NøgleId = 999 };
            Person p3 = new Person() { Fornavn = "Johan", Efternavn = "Hansen" };

            p1.Skriv();
            p2.Skriv();
            p3.Skriv();

            Person[] arr = new Person[3];
            arr[0] = p1;
            arr[1] = p2;
            arr[2] = p3;

            foreach (var item in arr)
            {
                item.Skriv();
            }

            Console.ReadKey();

        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual void Skriv()
        {
            Console.WriteLine(""+Fornavn+" "+Efternavn);
        }
    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine(""+Fornavn+" "+Efternavn+ " Klasselokale: "+Klasselokale);
        }
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }

        public override void Skriv()
        {
            Console.WriteLine("" + Fornavn + " " + Efternavn + " NøgleID: " + NøgleId);
        }
    }


}
