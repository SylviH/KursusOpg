using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedArving2
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning terning = new Terning();
            LudoTerning ludoTerning = new LudoTerning();
            bool bl = ludoTerning.ErStjerne();
            string vl;

            bool b = ludoTerning.ErGlobus();
            string v;

            if (b == true)
            {
                v = "Globus";
            }
            else
            {
                v = ludoTerning.Værdi.ToString();
            }

            if (bl == true)
            {
                vl = "Stjerne";
            }
            else
            {
                vl = ludoTerning.Værdi.ToString();
            }

            Console.WriteLine("Terning har slået: "+"["+terning.Værdi+"]");
            Console.WriteLine("LudoTerning har slået: " + "[" + vl + "]");
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

    public class LudoTerning : Terning
    {
       
        public LudoTerning() : base()
        {

        }

        public LudoTerning(int værdi) : base(værdi)
        {

        }


        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
    }
}
