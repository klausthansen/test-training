using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregninger.Adder(2, 3);

            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();
            }
    }
}
    public class Beregninger
        {
        public static int Adder(int a, int b) {
        return a + b;
        }
        public static int Subtract(int a, int b)
        {
        return a - b;
        }
        private Beregninger()
        {

        }
        }
}


