using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgPolymorfi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyr = new Dyr[20];

            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            Console.ReadKey();
        }
    }

    public abstract class Dyr
    {

        static Random rnd = new Random();
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder:"+Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            
            
           
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int randomTal = rnd.Next(1, navne.Length);
            string dyrenavn = navne[randomTal];

            if (randomTal % 2 ==0)
            {
                Dyr hund = new Hund() { Navn = dyrenavn };
                return hund;
            }
            else
            {
                Dyr kat = new Kat() { Navn = dyrenavn };
                return kat;
            }
            
        }
    }

    public class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder:"+Navn);
        }
    }

    public class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder:"+Navn);
        }
    }
}
