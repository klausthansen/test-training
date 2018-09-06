using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Efternavn = "Hansen";
            p1.Fornavn = "Kurt";
            p1.Fødselsår = 1980;

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());


            Person p2 = new Person("Kurt", "Johansen", 2006);


            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
}
class Person
{
    public string Fornavn;
    public string Efternavn;
    public int Fødselsår;

    public string FuldtNavn()
    {

        return $"{Fornavn } { Efternavn}";

    }

    public int EstimeretAlder()
    {
        int år = DateTime.Now.Year;
        return år - this.Fødselsår;
    }

    // default constructor

    public Person()

    {

        this.Fornavn = "";

        this.Efternavn = "";

    }



    // Custom constructor

    public Person(string fornavn, string efternavn, int fødselsår)

    {

        this.Fødselsår = fødselsår;

        this.Fornavn = fornavn;

        this.Efternavn = efternavn;

    }
}

