using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund { Alder = 9, Navn = "Lady" };
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
                
            }

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
                
            }
            Console.ReadKey();
        }

    }

    class Hund:IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {

           var i = (Hund)obj;
            return this.Alder.CompareTo(i.Alder);
        }
    }
}
