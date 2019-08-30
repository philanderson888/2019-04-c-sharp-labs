using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_26_methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            // void method
            
            // return int
            int ReturnNumber()
            {
                return 12;
            }

            // return string
            string ReturnText()
            {
                return "some text";
            }

            // CALL THE METHODS
            ReturnNumber();    // WASTING THE OUTPUT; NOT USING IT!!!
            ReturnText();
            // use the output
            var output1 = ReturnNumber();
            var output2 = ReturnText();
            // print outputs
            Console.WriteLine($"output 1 is {output1} and output 2 is {output2}");
            Console.WriteLine($"output 1 is {ReturnNumber()} and output 2 is {ReturnText()}");


            // PASS IN INPUT ALSO INTO A METHOD
            void PrintNumber(int myNumber)
            {
                Console.WriteLine($"Your number is {myNumber}");
            }

            PrintNumber(10);
            PrintNumber(100);
            PrintNumber(1000);


            // send in data and get data back
            double Cube(int myNumber)
            {
                return Math.Pow(myNumber, 3);
            }

            Console.WriteLine(Cube(10));
            Console.WriteLine(Cube(11));
            Console.WriteLine(Cube(12));

        }
    }



}
