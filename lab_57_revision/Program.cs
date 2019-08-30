using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_57_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog(100); // d is 'instance'
            var s = new Spaniel();
            s.Height = 100000;
            s.Height = 400;

            var p = new Parent();
            var c1 = new Child1();
            short s1 = 12345;
            long l = 123456789012345678;

            object o;
            int i;
            

        }
    }

    class Dog {
        public int Height { get; set; }
        internal int Length { get; set; }
        protected int weight { get; set; }
        private int _age { get; set; }
        public Dog() { }  // default constructor
        
        // constructor
        public Dog(int height) {
            this.Height = height;
        }
    }

    class Spaniel : Dog
    {
        public Spaniel()
        {
            
        }
    }


    class Parent {
        public virtual void HaveParty() { Console.WriteLine("parent fun"); }
    }

    class Child1 : Parent {
        public override void HaveParty() { Console.WriteLine("child1 fun"); }
    }
    class Child2 : Parent {
        public override void HaveParty() { Console.WriteLine("child2 fun"); }
    }
    class Child3 : Parent {
        public override void HaveParty() { Console.WriteLine("child3 fun"); }
    }

}
