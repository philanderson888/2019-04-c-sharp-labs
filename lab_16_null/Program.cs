using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_16_null
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = null;
            string y = "";
            Console.WriteLine(x == y);  // false

            // If reading from database and there
            // literally is no data coming in,
            // then that's a 'null'

            // integers : default value is '0'
            int z = new int();
            Console.WriteLine(z);

            // Scenario : reading numbers from database
            // Want to differentiate from '0' and blank space

            // nullable integer
            int? zz = 0;
            zz = null;



        }
    }
}
