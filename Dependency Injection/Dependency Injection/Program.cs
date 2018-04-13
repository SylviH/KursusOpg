using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(1);
                Console.WriteLine(m.FindTalTilTerning());
                ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
                Console.WriteLine(f.FindTalTilTerning());
            }

            {
                TilfældighedsGeneratorMock m = new TilfældighedsGeneratorMock(1);
                Terning t1 = new Terning(m);
                Console.WriteLine(t1.Værdi);

                TilfældighedsGeneratorFramework f = new TilfældighedsGeneratorFramework();
                Terning t2 = new Terning(f);
                Console.WriteLine(t2.Værdi);

                ITilfældighedsGenerator maximus = new TilfædlighedsGeneratorMaximus();
               
                    Terning t3 = new Terning(maximus);

                    Console.WriteLine("Maksimus: " + t3.Værdi);
                    Console.ReadKey();
                                
            }
        }
    }

    public interface ITilfældighedsGenerator
    {
        int FindTalTilTerning();
    }

    public class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
    {
        private static System.Random rnd = new System.Random();

        public int FindTalTilTerning()
        {
            return rnd.Next(1, 7);
        }
    }

    public class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        private int tal;
        public TilfældighedsGeneratorMock(int tal)
        {
            this.tal = tal;
        }
        public int FindTalTilTerning()
        {
            return this.tal;
        }
    }

    public class TilfædlighedsGeneratorMaximus : ITilfældighedsGenerator
    {
        private int MaksimusTal = 1;
        public int FindTalTilTerning()
        {
            ++MaksimusTal;
            if (MaksimusTal ==6)
            {
                MaksimusTal = 1;
            }
            return MaksimusTal;
        }
    }


    class Terning
    {
        private ITilfældighedsGenerator generator;

        public int Værdi { get; set; }

        public Terning(ITilfældighedsGenerator rnd)
        {
            generator = rnd;
            Ryst();
        }

        public void Ryst()
        {
            this.Værdi = generator.FindTalTilTerning();
        }
    }
}
