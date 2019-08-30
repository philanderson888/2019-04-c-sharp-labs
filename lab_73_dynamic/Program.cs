using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_73_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 7;
            //x = "hi";   invalid
            Console.WriteLine(x.GetType());

            dynamic y = 7;
            
            y = "hi";
            y = true;
            y = new int[10];

            Console.WriteLine(y.GetType());
        }
    }
}
