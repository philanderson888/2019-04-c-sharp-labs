using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_103_hw_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            if (null == null) {
                Console.WriteLine("null equals null");
            }
        }
    }

    public class Dog {
        public int Age { get; set; }
        public int Height { get; set; }
        public Dog() { }

        public int Grow(out int height)
        {
            height = -1;
            return -1;
        }






    }
}
