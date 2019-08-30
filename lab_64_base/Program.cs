using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_64_base
{
    class Program
    {
        static void Main(string[] args)
        {
            // parent : dothis
            var p1 = new Parent();
            p1.DoThis();
            // child : dothis
            var c1 = new Child();
            c1.DoThis();
        }
    }


    class Parent {
        public virtual void DoThis() {
            Console.WriteLine("I'm in the parent");
        }
    }
    class Child : Parent {
        public override void DoThis()
        {
            base.DoThis();
            Console.WriteLine("I'm in the child");
        }
    }
}
