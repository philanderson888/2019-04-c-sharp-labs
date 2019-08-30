using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_105_hw_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Parent{
        public string OutputText() {
            return "-1";
        }
    }

    public class Child : Parent { }
}
