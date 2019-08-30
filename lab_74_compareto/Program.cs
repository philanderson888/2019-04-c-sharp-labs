using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_74_compareto
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "hi";
            string y = "there";
            var output = x.CompareTo(y);
            var output2 = y.CompareTo(x);
            var output3 = x.CompareTo(x);
            Console.WriteLine($"{output}{output2}{output3}");

            var a = new Custom();
            var b = new Custom();
            var output4 = a.CompareTo(b);

        }
    }

    class Custom : IComparable
    {
        public int property01 { get; set; }
        public int CompareTo(object o) {
            return -1;
        }
    }
}
