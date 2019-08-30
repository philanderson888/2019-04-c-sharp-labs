using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_49_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            goto a;

            int counter = 0;

            while (true)
            {
                counter++;
                if (counter > 100000)
                {
                    throw new Exception("Number is too big");
                }
            }

            a:;

            Console.WriteLine("Program has finished");


        }
    }
}
