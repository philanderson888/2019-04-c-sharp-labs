using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_19_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // SAFE CASTING

            int i = 10;
            double d = i;


            // EXPLICIT (DANGEROUS) CASTING
            double dd = 10.79;
            int ii = (int)dd;
            Console.WriteLine(ii);

            // different to rounding

            Console.WriteLine(Math.Round(dd));
            Console.WriteLine(Math.Floor(dd));
            Console.WriteLine(Math.Ceiling(dd));


            // boxing is same as casting but to object

            int iii = 100;
            object ooo = iii;

            // unbox

            int jjj = (int)ooo;



        }
    }
}
