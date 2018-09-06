using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Fornavn = "Rasmus";
            p1.Efternavn = "Rinkenæs";
            p2.Fornavn = "John";
            p2.Efternavn = "Ib";

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p2.FuldtNavn());


        }
    }


    class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get
            {

                return efternavn;
            }

            set
            {
                if (value.Length < 4)
                {

                    efternavn = "";
                }

                else
                {
                    efternavn = value;
                }
            }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
}
