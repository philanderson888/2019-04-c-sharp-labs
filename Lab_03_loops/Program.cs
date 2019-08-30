using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // ALL PROGRAMMING

            // 4 types of loops

            // for..
            for(int i = 0; i < 10; i++)
            {

            }
            // step 3 ie 0,3,6,9,12
            for (int i = 0; i <= 30; i=i+3)
            {

            }

            int test = 100;
            // add 3
            test = test + 3;
            // or 
            test += 3;

            // while (condition is true) {  RUN SOME CODE }
            Console.WriteLine("\nwhile loop\n\n");
            int counter = 10;
            while (counter <= 20)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // do { some code } while(condition is true)
            // minimum one time - code will be executed
            Console.WriteLine("\n\ndo..while loop\n\n");
            counter = 10;
            do {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter <= 20);

            // foreach
        }
    }
}
