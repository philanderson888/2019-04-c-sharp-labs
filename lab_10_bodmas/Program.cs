using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_bodmas
{
    class Program
    {
        static void Main(string[] args)
        {

            // Got to get your BIDMAS clear!!!

            // 96 + 20 / 5 - 77 / 11

            //  96  +  4    -     7

            //  93

            // WRITE OUT ON COMPUTER AND GET ANSWER
            //  5 SQUARED * 13 CUBED - 7 / 4

            Console.WriteLine(5*5*13*13*13-(7/4.0));

            var FiveSquared = Math.Pow(5, 2);
            var ThirteenCubed = Math.Pow(13, 3);

            Console.WriteLine(FiveSquared*ThirteenCubed-(7/4.0));


            Console.WriteLine(Math.Sqrt(100));

            // modulus

            Console.WriteLine(100/8); // 12 WRONG - CARE!! integers yield integers!!!
            Console.WriteLine(100/8.0);  // 12.5 CORRECT
            Console.WriteLine(100%8); // 4 REMAINDER CORRECT
        }
    }
}
