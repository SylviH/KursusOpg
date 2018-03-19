using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgKlassarOgArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            YatzyBæger yatzyBæger = new YatzyBæger();
            yatzyBæger.Ryst();
            yatzyBæger.Skriv();
            Console.ReadKey();
            
        }

        
    }

    public class Terning
    {

        private int værdi;
        private static Random rnd = new Random();

        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            Værdi = værdi;
        }

        public int Værdi
        {
            get { return værdi; }
            set
            {
                if (value < 1 || value > 7)
                {
                    value = 1;
                }
                værdi = value;
            }
        }

        public int Ryst()
        {
            
            return this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");

        }


    }
}
