using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgKlassarOgArrays
{
    class YatzyBæger
    {
        private Terning[] terninger;

        public YatzyBæger()
        {

            terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }
            
            
            
        }

        public void Ryst()
        {
            foreach (var item in this.terninger)
            {
                item.Ryst();
            }
               
           
        }

        public void Skriv()
        {
            foreach (var item in this.terninger)
            {
                
                item.Skriv();
                Console.WriteLine();
                if (item.Værdi == 5)
                {
                    Console.WriteLine("*********");
                }
                
                
            }
        }
    }
}
