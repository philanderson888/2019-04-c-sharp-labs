using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_34_optional_and_named_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis(10, "hi", true);
            DoThis(10, "hi");
            DoThat(1, 2, 3, 4);
            DoThat(10,2);
            DoThat(d: 7, c: 6, a: 10);
        }

        static void DoThis(int x, string y, bool z = false)
        {

        }

        static void DoThat(int a, int b=5, int c=6, int d=7)
        {

        }
    }


}
