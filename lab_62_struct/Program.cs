using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_62_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Point();   // default constructor
            p01.X = 10;
            p01.Y = 11;
            var p02 = new Point(10, 11,12);   // with constructor
            var p03 = new Point(11, 12,13);
        }
    }

    class Parent {
        public int height { get; set; }
    }

    // Points on line : want very fast, not much detail inside (X,Y)
    struct Point
    {
        public int X;  // public fields no hiding
        public int Y;
        int Z;
        public Point(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
