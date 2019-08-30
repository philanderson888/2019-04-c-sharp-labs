using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_65_base_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent("bob");
            var c = new Child("tim");
        }
    }

    class Parent {
        public string Name;
        public Parent(string name)
        {
            this.Name = name;
        }
        public Parent() { }
    }

    class Child : Parent
    {
        public Child(string name) : base() { }
    }




}
