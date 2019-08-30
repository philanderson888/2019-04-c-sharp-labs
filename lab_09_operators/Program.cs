using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_operators
{
    class Program
    {
        static void Main(string[] args)
        {

            // increment operators - adding one!
            int x = 100;
            //  y=x  then x++ ie increment x by 1
            // so y=x=100 then x increments to 101
            int y = x++;  // same as int x=100; y=x; x++;
            // think answer is :     101         100
            // actual answer is :    
            Console.WriteLine($"x is {x} and y is {y}");

            // if we want expected results use this
            int a = 100;
            int b = ++a;
            // BOTH 101 AS EXPECTED
            // firstly increment a to 101 then b=a=101 after
            Console.WriteLine($"a is {a} and b is {b}");

            // GENERAL RULE = JUST ONLY USE ++; ON IT'S OWN SEPARATE LINE!!!

            // best way

            int r = 1000;
            r++;          // UP TO 1001
            int s = r;  // clear and no nonsense!!!  BOTH 1001


            // NOT OPERATOR
            //  !true=false

            bool isExcellent = true;
            bool isRubbish = false;

            Console.WriteLine(isExcellent);   // TRUE
            Console.WriteLine(!isExcellent);  // FALSE



        }
    }
}
