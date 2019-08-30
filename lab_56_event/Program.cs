using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_56_event
{
    class Program
    {
        // delegate : says that our event can only trigger methods which
        // have a set pattern
        delegate void MyDelegate();   // pattern : method must be void ... ()  
        // event now uses this delegate
        static event MyDelegate myEvent;   // create event; when it triggers any methods must match this pattern


        static void Main(string[] args)
        {
            // goal : replace manually calling 3 methods with 1 event which triggers
            // these methods 
            MyMethod01();
            MyMethod02();
            MyMethod03();

            // attach methods to our event
            myEvent += MyMethod01;  
            myEvent += MyMethod02;
            myEvent += MyMethod03;
            myEvent += MyMethod01;
            // call the event
            myEvent();
        }


        static void MyMethod01()
        {
            Console.WriteLine("Doing Something 01");
        }
        static void MyMethod02()
        {
            Console.WriteLine("Doing Something 02 ");
        }
        static void MyMethod03()
        {
            Console.WriteLine("Doing Something 03");
        }
    }
}
