using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // string
            string x = "hi";
            String y = " there";
            // use lowercase 'string'
            // uppercase String is when use String as a 'class'

            // concatenate
            Console.WriteLine(x+y);
            //  super-long strings this is MEMORY INEFFICIENT
            // stringbuilder : use to build very long strings
            var longString = new StringBuilder();
            for(int i = 0; i < 1000000; i++)
            {
                longString.Append($"adding{i}");
            }
           // Console.WriteLine(longString);

            // Integers ARE 32 BITS LONG!!!
            int anyNumber = 23456;
            Console.WriteLine(anyNumber.GetType());


            Console.WriteLine("Integer maximum values");
            Console.WriteLine($"2^32 is {Math.Pow(2,32)}");
            Console.WriteLine($"max and min values {int.MaxValue}," +
                $"{int.MinValue}");

            // SHORT
            short s = 12345;
            // INT
            int ii = 1234567890;
            // LONG
            long l = 1234567890123456789;

            // UNSIGNED integers : all positive 
            ushort ushort1 = 123;
            // can't be negative
          // ushort ushort2 = -10;

              //  uint
              //  ulong

        }
    }
}
