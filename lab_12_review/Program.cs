using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12_review
{
    class Program
    {
        static void Main(string[] args)
        {

            // DATA TYPES
            // int

            // signed
            short x;    // 16 bit
            Int16 xx;  // same thing

            long l;     // 64 bit
            Int64 ll;

            int i;      // 32 bit default  (31 for data, 1 for sign) 
            Int32 ii; 

            // unsigned : positive only
            ushort u1;

            // danger : integer division TRUNCATES!!!! CARE!!!!
            Console.WriteLine(12 / 6); // expected 2
            Console.WriteLine(12 / 5); // expected 2.something but get 2

            Console.WriteLine(12.0 / 5); // 2.4
            Console.WriteLine(12 / 5.0); // 2.4

            // decimals : default is DOUBLE AND HAS 64 BIT PRECISION

            var num1 = 1.23456778901234567890; // DOUBLE 64 BITS 
            var num2 = 1.23456778901234567890F;  // turns into FLOAT 32 BIT PRECISION
            var decimal01 = 1.23456789012345678901234567890123456789012345678901M;
            // super long 128 bit decimal type

            // float 32 bit
            // double 64 bit
            // decimal 128 bits long (precise for money)

            // INTEGERS
            // DECIMALS

            // division
            Console.WriteLine(100/8);    // 12 INCORRECT (INTEGER WHOLE NUM ONLY)
            Console.WriteLine(100/8.0);  // 12.5 CORRECT 
            Console.WriteLine(100%8);    // MODULUS  REMAINDER 4 CORRECT


            // LOOPS : 4 TYPES

            // FOR

            // FOREACH
            string[] myArray = new string[] { "one", "two", "three" };

            // WHILE

            // DO.WHILE

            // BODMAS / BIDMAS   Brachet, operator/indexes, dm , as

            //NAMESPACE : SEPARATE CODE
            // main() always runs first
            //  .sln     SOLUTION  CONTAINER FOR MULTIPLE PROJECTS
            //  .csproj  PROJECT ==> GENERATES EXE OR DLL LIBRARY

            // OPERATOR

            // increment  ++  and decrement --
            // rule : put ++ on separate line

            // boolean
            var isOff = true;
            var isOn = false;














        }
    }
}
