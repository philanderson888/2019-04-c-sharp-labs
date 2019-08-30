using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_35_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent("fred",32);
            var p2 = new Parent();
        }
    }

    class Parent {
        public string Name { get; set; }  //  Property
        public int Age;                   //  Field
        // create a constructor : same name as class
        // this keyword refers to 'instance' ie 'p' above
        public Parent(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
        // default one does not exist !!
        public Parent() { }
    }

   // class Child : Parent { }
}
