using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> plist = new List<Person>();
            Person p1 = new Person { ID = 1, Navn = "Per" };
            Person p2 = new Person { ID = 2, Navn = "Ole" };
            Person p3 = new Person { ID = 3, Navn = "Søren" };
            Person p4 = new Person { ID = 4, Navn = "Kim" };

            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);

            foreach (var item in plist)
            {
                Console.WriteLine("Person -> ID-nr: "+item.ID+"  Name: "+item.Navn);
            }
            Console.ReadKey();

            Dictionary<int, Person> keyValuePairs = new Dictionary<int, Person>();
            keyValuePairs.Add(1, p1);
            keyValuePairs.Add(2, p2);
            keyValuePairs.Add(3, p3);
            keyValuePairs.Add(4, p4);

            var p = keyValuePairs[3];
            Console.WriteLine(p.Navn);
            Console.ReadKey();

        }
    }

    class Person
    {
        public int ID { get; set; }
        public string Navn { get; set; }
    }
}
