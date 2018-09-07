using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person P1 = new Person() { Efternavn = "Svendsen", Fornavn="Ib" };

            Elev e1 = new Elev() { Efternavn="Kjelldahl",Fornavn="Johan", Klasseværelse="Fysiklokalet"};

            Instrutør I1 = new Instrutør() { Efternavn = "Rasmussen", Fornavn = "Svend", NøgleId = 4711 };
            Console.WriteLine(P1.FuldtNavn());

            Console.Write(e1.FuldtNavn());
            Console.Write (", ");
            Console.WriteLine(value:e1.Klasseværelse);            
            Console.Write(I1.FuldtNavn());
            Console.Write(", ");
            Console.WriteLine(value:I1.NøgleId);
        // Hold console åben ved debug

        if (System.Diagnostics.Debugger.IsAttached)

        {

            Console.Write("Press any key to continue . . . ");

            Console.ReadKey();

        } 
             
             
             
             
        }
    }

    public class Person
    {
        public string Fornavn { get; set; }


        public string Efternavn { get; set; }


        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

    }
    public class Elev : Person
    {
        public string Klasseværelse { get; set; }
       

    }
    public class Instrutør : Person
    {
        public int NøgleId { get; set; }

    }
}
