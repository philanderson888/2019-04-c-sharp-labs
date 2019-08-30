using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // FOR
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"Your number is {i}");
                Console.WriteLine($"Number squared is {i*i}");
            }

            // WHILE
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"While loop : number is {counter}");
                counter++;
            }

            // DO..WHILE
            counter = 0; // reset
            do
            {
                Console.WriteLine($"Do..While : number is {counter}");
                counter++;
            }
            while (counter < 10);


            // ARRAY

            // ARRAY is a FIXED-SIZE STRUCTURE which is very fast to access.

            // DECLARE
            int[] myIntegerArray = new int[10];    // size has 10 boxes for integers
            string[] myStringArray = new string[10];    // size has 10 boxes for strings

            // ACCESS ONE ITEM
            // FIRST ITEM HAS INDEX 0
            myIntegerArray[0] = 100;
            myIntegerArray[1] = 101;
            myIntegerArray[2] = 102;
            // LAST ITEM : INDEX = SIZE-1  IE 10-1 = [9]
            myIntegerArray[9] = 999;

            // FOREACH : COUNT OVER EVERY ITEM IN ARRAY
            foreach(int item in myIntegerArray)
            {
                Console.WriteLine($"Item in array is {item}");
            }

            // REPEAT FOR A STRING ARRAY
            string[] myArray  = new string[3];
            // FILL ARRAY AT SAME TIME : STRING 'LITERALS' GOING IN CODE
            string[] myArray2 = new string[]{ "one", "two", "three" };
            // fill the array 
            myArray[0] = "one";
            myArray[1] = "two";
            myArray[2] = "three";
            // foreach loop to print the items
            // PRINT myArray
            foreach(string item in myArray)
            {
                Console.WriteLine(item);
            }
            foreach(string item in myArray2){
                Console.WriteLine(item);
            }
            // NOTE CAN USE FOR - start at 0 and count to the array length - 1 
            for(int i = 0;i < myArray2.Length; i++)
            {
                Console.WriteLine($"Using for loop over array - {myArray2[i]}");
            }

            // 10-MINUTE LAB : BUILD FOR LOOP, THEN ALSO BUILD A WHILE LOOP.
            // BOTH WILL COUNT TO 1000 (step 50)
            for(int i = 0; i < 1000; i+=50)
            {
                Console.WriteLine($"for loop to 1000 - {i}");
            }

            counter = 0;
            while (counter < 1000)
            {
                Console.WriteLine($"While loop to 1000 - {counter}");
                counter+=50;
            }
            // BONUS : FILL ARRAY WITH 1000 NUMBERS AND PRINT OUT ALSO
            // VAR JUST MEANS 'any variable type' - let the computer decide
            // (ALREADY STATED TYPE ON RIGHT IE int[1000]
            var myLargeArray = new int[1000];
            for (int i = 0; i < myLargeArray.Length; i++)
            {
                // fill the array
                myLargeArray[i] = i;
            }
            for (int i = 0; i < myLargeArray.Length; i++)
            {
                // print the items
                myLargeArray[i] = i;
            }

        }
    }
}
