using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_75_checked
{
    class Program
    {
        static void Main(string[] args)
        {
            short s = 12345;
            int i = 1234567890;
            long l = 1234567890123456789;

            var largeNumber = int.MaxValue;   //  2 147 483 647 
            var largeUnsignedNumber = uint.MaxValue; //  4 ... ... ..5
                                            // 2 power 32 = 4 294 967 296
            var smallNumber = int.MinValue;   // 

            Console.WriteLine(largeNumber);
            largeNumber++;
            Console.WriteLine(largeNumber);   // starts again at lowest
            largeNumber++;
            Console.WriteLine(largeNumber);
            largeNumber++;
            Console.WriteLine(largeNumber);

            // INTEGERS BY DEFAULT : NO RUN TIME CHECKING FOR OVERFLOW
            // EXCEPTION 

            // HEAVY ON CPU SO DON'T USE UNLESS NEED IT
            checked
            {
                var bigNumber = int.MaxValue;
              //  var biggerBigNumber = bigNumber * 10;
            }

            // IF USING LARGE NUMBERS THEN USE
            var hugeNumber = double.MaxValue;
            Console.WriteLine(hugeNumber);
            var hugeNumber2 = decimal.MaxValue;
            Console.WriteLine(hugeNumber2);



        }
    }
}
