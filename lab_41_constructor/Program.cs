using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_41_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. instantiate with default constructor
            // var p = new MyClass();

            // 3. then create proper constructor
            // default one does not work any more!
            var q = new MyClass("hi", 22);
            q.Property03 = 100;

            var output = Math.Pow(2, 3);

        }
    }

    // 1. code a class with two properties string and int
    class MyClass
    {
        public string Property01 { get; set; }
        public int Property02 { get; set; }

        public int Property03
        {
            get
            {
                return this.Property03;
            }
            set
            {
                Property03 = value;
            }
        }

        public MyClass(string x, int y)
        {
            this.Property01 = x;
            this.Property02 = y;
        }
    }

}
