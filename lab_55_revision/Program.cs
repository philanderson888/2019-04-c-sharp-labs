using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_55_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object which is called 'instance'
            var d1 = new Dog();
            d1.Bark();
            d1.Age = 5;
            // can't reach STATIC using d1 - use Dog!!!
            Console.WriteLine(Dog.numLegs);  //4 
            // dogfactory
            List<Dog> doglist = new List<Dog>();
            for (int i = 0; i < 100000; i++)
            {
                doglist.Add(new Dog());
                // or
                var d = new Dog();
                d.Age = -4;
                doglist.Add(d);
            }
        }
    }


    // class is a blueprint for creating dogs (objects which we call dog)
    class Dog
    {
        // field
        public int _private;
        // attached to DOG CLASS !!!  STATIC !!!!
        // access via Dog.numLegs
        public static readonly int numLegs = 4;
        // property
        public int PublicSomething { get; set; }
        // property with validation code
        public int Age {
            get {
                return Age;
            }
            set {
                if (Age > 0)
                {
                    this.Age = value;
                }
            }
        } // field // instance field
        public void Bark() { }  // instance method
    }
}
