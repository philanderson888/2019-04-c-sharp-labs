using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_18_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 0b10101010; // latest c# has literal binary type

            // also use hex

            byte bb = 0xFF;   // f=15 decimal = 1111 binary
                              //   FF = 11111111 in binary

            byte bbb = 15;


            char c = 'f';
            Console.WriteLine(c);
            // convert to a number using (int) (casting)
            Console.WriteLine((int)c);

            char c02 = 'g';
            Console.WriteLine(c02);
            // convert to a number using (int) (casting)
            Console.WriteLine((int)c02);

            // Convert a number to a character
            char c03 = (char)104;
            Console.WriteLine(c03);


            string s = "abcdef";
            foreach (char item in s)
            {
                Console.WriteLine(item);
            }



            // raw objects

            object o1 = 10;
            o1 = "hi";
            Console.WriteLine(o1);
            object o2 = "hi";
            object o3 = false;

            // custom
            // key/value pairs
            object o4 = new
            {
                name = "Bob",
                dob = "20/3/2000"
            };


            // BAD BAD CODING BUT JUST FOR ILLUSTRATION!!!
            dynamic o5 = 12;
            o5 = "hi";
            o5 = false;


            // const

            const string DONT_CHANGE_ME = "I don't change";
            // DontChangeMe = "to something else";








        }




           
    }
}
