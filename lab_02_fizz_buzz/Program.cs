using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // count to 100
            // start from 1, up to 100, increment by 1
            for(int i = 1; i <= 100; i++)
            {
                // if (i % 15 == 0) { Console.WriteLine($"{i} fizzbuzz"); }

                Console.Write(i);

                if (i % 3 == 0) { Console.Write(" fizz"); }

                if (i % 5 == 0) { Console.Write(" buzz"); }

                Console.WriteLine();


                int x = 10;
                
                // TEST FOR X LESS THAN 100
                if (x < 100) { // do this
                }
                
       
                
            }
        }
    }
}
