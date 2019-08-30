using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_53_reference_value_type
{
    class Program
    {
        static void Main(string[] args)
        {
            // value types  -- WORK AS EXPECTED!!!!!!!!!!!!!!
            int x = 100;
            int y = x;
            Console.WriteLine($"x is {x} and y is {y}");   // 100,100
            // change ONE
            x = 400;
            Console.WriteLine($"x is {x} and y is {y}");  // 400,100


            // reference types

            var array01 = new int[] { 100, 200, 300 };
            var array02 = array01;

            // before
            foreach (int item in array01) { Console.WriteLine(item); }
            foreach (int item in array02) { Console.WriteLine(item); }
            // change ONE item
            array02[2] = 99999999;
            // after
            foreach (int item in array01) { Console.WriteLine(item); }
            foreach (int item in array02) { Console.WriteLine(item); }  
            
            // Change has affected BOTH ARRAYS!

        }
    }
}
