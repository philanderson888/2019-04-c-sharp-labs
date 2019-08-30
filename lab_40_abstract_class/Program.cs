using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_40_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // var h = new Holiday();
            var h = new LetsGo(); // hey we're off!
        }
    }

    abstract class Holiday
    {
        // REAL METHOD
        void VisitGeysers() { 
            // wow - have a great time! 
        }
        // ABSTRACT METHOD
        public abstract void GettingToIceland();
    }

    class LetsGo : Holiday
    {
        public override void GettingToIceland()
        {
            // yes we do travel by plane and hire a car
        }
    }
}
