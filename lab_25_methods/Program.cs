using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_25_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            // METHOD IS A FUNCTION WHICH WE CAN CALL!

            // ALWAYS HAS A 'RETURN TYPE' 
            // VOID IS USED FOR SIMPLE TYPES : RETURNING NOTHING

            // DECLARING BUT NOT RUNNING THE METHOD : STATING WHAT IT DOES
            void DoThis()
            {
                Console.WriteLine("I am doing something");
            }
            void DoThis2()
            {
                Console.WriteLine("I am doing something 2");
            }
            void DoThis3()
            {
                Console.WriteLine("I am doing something 3");
            }


            // now run it
            DoThis(); ///RUN THE METHOD !!!
            DoThis2();
            DoThis3();
            DoThis();
            for(int i = 1; i <= 5; i++)
            {
                DoThis();
            }

        }
    }
}
