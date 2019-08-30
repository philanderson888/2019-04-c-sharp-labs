using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_47_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                if (i == 5 || i == 6)
                {
                    continue;
                }

                
                Console.WriteLine(i);
            }

            int counter = 0;
            while (counter < 10)
            {
                if (counter == 8)
                {
                    break;
                }
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
