using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_36_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // must instantiate first
            var p = new Parent();
            // can now run INSTANCE METHOD
            p.DoThis();
            p.DoThis(10);
            p.DoThis("hi");
            p.DoThis(10, "hi", true);
            
            // or a STATIC METHOD
            Parent.DoThat();  // same for all instances
            
        }
    }

    class Parent {
        public void DoThis() { Console.WriteLine("no parameters"); }
        public void DoThis(int x) { Console.WriteLine("integer parameter"); }
        public void DoThis(string y) { Console.WriteLine("string parameter"); }
        public void DoThis(int x, string y, bool z) { Console.WriteLine("3 parameters"); }
        public static void DoThat() { Console.WriteLine("static method"); }
    }

}
