using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f = new Faktura() { Nr = 4711, Kunde = "Johansen", Dato = DateTime.Now.Date };


            Console.WriteLine(value: f);

        }
    }
    class Faktura
    {
        public int Nr { get; set; }
        public DateTime Dato { get; set; }
        public string Kunde { get; set; }


    
    
    

        public override string ToString()

        {

            return $"Faktura til {Kunde} nr {Nr} fra {Dato:D}.";

        }
    }
}
