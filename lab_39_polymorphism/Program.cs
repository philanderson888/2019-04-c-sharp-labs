using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_39_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new BaseParent();
            p.HaveAParty();
            var c = new DerivedChild();
            c.HaveAParty();
            var d = new DerivedTeenager();
            d.HaveAParty();
        }
    }

    class BaseParent {
        // Parent is VIRTUAL (can be overridden)
        public virtual void HaveAParty() { Console.WriteLine("Having A Dinner Party"); }
    }

    class DerivedChild : BaseParent{
        // child OVERRIDES code of parent (optionally)
        public override void HaveAParty() { Console.WriteLine("Having A Swimming Party"); }
    }

    class DerivedTeenager : BaseParent {
        // child OVERRIDES code of parent (optionally)
        public override void HaveAParty() { Console.WriteLine("Going Out With Friends"); }
    }
}
