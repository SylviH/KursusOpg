using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Søren" };
            Personer1 personer1 = new Personer1();
            personer1.Tilføj(p1);
            Console.WriteLine("" + personer1.Name);
            Console.ReadKey();


        }

        class Person
        {
            public string Name { get; set; }
        }

        class Instructor : Person
        {
            public int Id { get; set; }
        }

        class Kursist : Person
        {
            public int Nøgle { get; set; }
        }

        class Personer1
        {

            List<Person> pList = new List<Person>();
            public string Name { get; set; }
            public void Tilføj(Person
                p)
            {
                pList.Add(p);
                foreach (var item in pList)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        class Personer2<T>
        {

            List<T> pList2 = new List<T>();

            public void Tilføj(T t)
            {
                pList2.Add(t);
            }
        }
    }
}
