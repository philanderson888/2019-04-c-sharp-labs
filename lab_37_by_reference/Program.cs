using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_37_by_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare integer
            int x = 1000;
            DoThis(ref x);
            Console.WriteLine($"x in the main method is {x}");
        }

        static void DoThis(ref int x) {
            x = x + 1;
            Console.WriteLine($"x in the method is {x}");
        }
    }
}
