using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesOPG
{
    
    class Program
    {
        static void Main(string[] args)
        {
           
            int res = Beregner(2, 2, Plus);
            Console.WriteLine(res);
            res = Beregner(3, 3, Gange);
          
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static int Beregner (int a , int b, Func<int,int,int> funktion)
        {
            return funktion(a, b);
        }
        public static int Plus(int a , int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a-b;
        }

        public static int Divider(int a, int b)
        {
            return a/b;
        }

        public static int Gange(int a, int b)
        {
            return a*b;
        }

       
    }


}
