using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { Navn = "Søren", Saldo = 5000, kreditMax = -500};
            k.KreditOverskredet += (s, e) =>
            {
                Console.WriteLine("Kredit overskredet");
            };

            k.Køb(1000);
            k.Køb(6000);
            Console.ReadKey();
        }



    }

    public class Kunde
    {
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int kreditMax { get; set; }

        public event EventHandler KreditOverskredet;
        public void Køb ( int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn,værdi);
            this.Saldo -= værdi;
            if (Saldo < kreditMax)
            {
                if (KreditOverskredet!= null)
                {
                    KreditOverskredet(this, new EventArgs());
                }
                
            }
        }
}
}

   


