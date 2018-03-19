using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Sylvi";
            p.Efternavn = "Hansen";
            Console.WriteLine(""+p.FuldtNavn());
            Console.ReadKey();

        }

        public class Person
        {

            private string efternavn;
            public string Fornavn { get; set; }
           

            public string Efternavn
            {
                get { return efternavn; }
                set
                {
                    if (value.Length < 3)
                    {
                        efternavn = "";
                    }
                    
                    
                        efternavn = value;
                    
                }
            }

            public string FuldtNavn()
            {
                string fuldtnavn = "" + Fornavn + " " + Efternavn;
                return fuldtnavn;
            }


        }
        
        
        
    }
}
