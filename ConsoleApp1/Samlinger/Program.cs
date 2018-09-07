using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger
{
    class Program
    {
        static void Main(string[] args)
        {   
            //kalder class derfor Person()
            List<Person> lst1 = new List<Person>();
            
            lst1.Add(new Person() { Id = 1, Navn= "Søren"});
            lst1.Add(new Person() { Id = 2, Navn = "Johan" });
            lst1.Add(new Person() { Id = 3, Navn = "Inga" });

            foreach (var item in lst1)
            {
                Console.WriteLine(item.Navn);
            }
            //dictionary (nøgle, værdi)
            Dictionary<int,Person> lst2 = new Dictionary<int,Person>();
            lst2.Add(1,new Person() {Id= 1, Navn="Kurt" });
            lst2.Add(2,new Person() {Id= 2, Navn="Ulla" });
            lst2.Add(3,new Person() { Id = 3, Navn = "Ida" });

            var p = lst2[2];
            Console.WriteLine(p.Navn);


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
