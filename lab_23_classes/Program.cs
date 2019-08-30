using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_23_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first 'object' from blueprint 'class'
            var p01 = new Parent();
            // p01 is new object
            p01.Age = 21;
            p01.Height = 1500;
            p01.Name = "George";

            Console.WriteLine($"Person has name {p01.Name}, height {p01.Height} and age {p01.Age}");
            p01.Grow();
            // check if person has grown
            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
        }
    }

    class Parent
    {
        public string Name;
        public int Age;
        public double Height;

        // Method / Function
        public void Grow()
        {
            Age++;
        }
    }
}
