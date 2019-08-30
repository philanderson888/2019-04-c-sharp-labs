using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_33_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis(10, "hello world");
            var listOutput = BuildAList(100, 200, 300, out bool isLong); // using list
            listOutput.ForEach(item => Console.WriteLine(item));
            Console.WriteLine($"Is it a long list? {isLong}");
        }

        static void DoThis(int x, string y)
        {
            Console.WriteLine(x + " " + y);
        }

        static List<int> BuildAList(int x, int y, int z, out bool isLongList)
        {
            var list = new List<int>();
            list.Add(x);
            list.Add(y);
            list.Add(z);
            if (list.Count > 10)
            {
                isLongList = true;
            }
            else
            {
                isLongList = false;
            }
            return list;
        }

    }
}
