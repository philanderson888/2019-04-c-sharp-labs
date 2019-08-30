using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_32_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. in another method (not recommended as gets messy with 'nesting')

            void DoSomething()
            {
                Console.WriteLine("Hey I am doing something");
            }

            // call it
            DoSomething();

            // call static method
            DoSomethingElse();

 
        }


        // 2. In the same class using STATIC KEYWORD WHICH ATTACHES METHOD TO THIS CLASS
        static void DoSomethingElse()
        {
            Console.WriteLine("Hey I'm now doing something else");
        }


    }


    // 3. in another class either as STATIC or INSTANCE method

    class Dog
    {
        // instance method
        public void Bark()
        {
            Console.WriteLine("dog is now barking loudly");
        }

        // static field
        public static int NumLegs = 4;



    }

}
