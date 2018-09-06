using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Navn = "Soda";
            v1.Pris = 42;
            Console.WriteLine(v1.medMoms());

        }
    }

    public class Vare
    {


        public Vare()
        {

        }

        public Vare(string navn,double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
            //Console.WriteLine(this.medMoms);
        }

        private string navn;
        public String Navn
        {
            get { return navn;

            }
            set { navn = value;
            }
        }
        private double pris;

        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }

        public double medMoms()
        {
            return this.pris*1.25;
        }
    }

}


