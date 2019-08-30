using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_28_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;

            if (x == 10) { Console.WriteLine("x is 10"); }
            else if (x == 20) { Console.WriteLine("x is 20"); }
            else if (x == 30) { Console.WriteLine("x is {0}",x); }
            else if (x == 40) { Console.WriteLine("x is " + x); }
            else { Console.WriteLine($"x is neither 10 nor 20 but is {x}"); }


            // ternary shorthand version of if..else
            // IF (CONDITION)      ?       IF TRUE           :   IF FALSE   ;
            var output = (x == 100) ? "true" : "false";
            Console.WriteLine(output);

        }
    }
}
