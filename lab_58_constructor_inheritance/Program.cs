using System;

namespace lab_58_constructor_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            var d1 = new Dog(10);
            var s = new Spaniel(10);
            //var s1 = new Spaniel(10);   // CONSTRUCTOR IS NOT INHERITED
            d.Grow();
            s.Grow();    // METHOD IS INHERITED 
            const int DONT_CHANGE_ME= 500;
            // DONT_CHANGE_ME = 600;
            //d.NumLegs = 5;
            Console.WriteLine(EngineeringConstants.Constant01);
        }

        void DoThis(int a, int b, int c,int zebra, int cobra) {
            // deal with a PRIVATELY IN HERE
        }
    }

    public class Dog {
        public int Age { get; set; }
        public readonly int NumLegs = 4;
        // constructor
        public Dog(int Age)
        {
            this.Age = Age;
        }
        public Dog() { }
        public void Grow() { Age++; }  // yes this is inherited
    }
    class Spaniel : Dog {
        // Constructor must be made here also
        public Spaniel(int anyvariable) {
            this.Age = anyvariable;
        }

    }

    public static class EngineeringConstants
    {
        public static readonly double Constant01 = 2.45793;
    }

}
