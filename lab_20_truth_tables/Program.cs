using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_20_truth_tables
{
    class Program
    {
        static void Main(string[] args)
        {

            // and

            Console.WriteLine(1&1);
            Console.WriteLine(0&0);
            Console.WriteLine(1&0);
            Console.WriteLine(0&1);

            // or

            Console.WriteLine(1|1);
            Console.WriteLine(0|0);
            Console.WriteLine(1|0);
            Console.WriteLine(0|1);


            // and with &&
            // or with ||

            // in real code we use && or || because it's quicker

            Console.WriteLine(true&&true); //true
            Console.WriteLine(false&&true); // false

            Console.WriteLine(true&&true&&true&&true);


            //xor
            Console.WriteLine(1^1);

        }
    }
}
