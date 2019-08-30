using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_24_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();
            p01.Name = "Father";
            var c01 = new Child();
            c01.Name = "Child";
            // give age
            c01.Age = 12;
            // make grow in loop : 10 times
            c01.Grow();
            c01.Grow();
            Console.WriteLine(c01.GrowReturningAge());  //increase age, print new age
            Console.WriteLine(c01.GrowReturningAge());
            Console.WriteLine(c01.GrowReturningAge());
            var newAge = c01.GrowReturningAge();
            newAge = c01.GrowReturningAge();
        }
    }

    class Parent {
        public string Name;
        public int Age;
        // age
        public void Grow() {
            Age++;
        }
        // grow
        public int GrowReturningAge()
        {
            Age++;
            return Age;
        }
    }

    class Child : Parent { }
}
