using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_54_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.HaveAParty();
            
            var c1 = new Child1();
            c1.HaveAParty();
            var c2 = new Child2();
            c2.HaveAParty();
            var c3 = new Child3();
            c3.HaveAParty();
            var c4 = new Child4();
            c4.HaveAParty();

        }
    }
    /// <summary>
    /// This is a description of some amazing code
    /// writen by an amazing coder
    /// happy coding
    /// </summary>
    public class Parent {
        /// <summary>
        /// here is an amazing piece of code
        /// </summary>
        public virtual void HaveAParty() { Console.WriteLine("Parent - posh dinner party"); }
    }
    public class Child1 : Parent {
        public override void HaveAParty() { Console.WriteLine("Child1 is swimming"); }
    }
    public class Child2 : Parent
    {
        public override void HaveAParty() { Console.WriteLine("Child2 is abseiling"); }
    }
    public class Child3 : Parent
    {
        public override void HaveAParty() { Console.WriteLine("Child3 is dancing"); }
    }
    public class Child4 : Parent
    {
        public override void HaveAParty() { Console.WriteLine("Child4 is reading books"); }
    }
}
