using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTests
{
    public class SomeTest
    {
        // takes a string change any text into lowercase then uppercase on repeat, ignoring spaces
        // Hello => hElLo first character should be a lowercase
        public string TextToSpongeBobMeme(string str) {

            return "";
        }

        // takes 3 words, return a string removing the middle word leaving one space
        public string RemoveMiddleWord(string str) {

            return "";
        }

        // takes an array of ints, return the sum of the array NOT INCLUDING THE LARGEST NUMBER
        public int SumIgnoringMax(int[] intArr) {
            
            return -1;
        }

        // takes 2 ints which decides how high the pyramid goes
        /*example for 5, 9

             *
            ***
           *****
          *******
         *********
     
        */
        public char[,] Pyramid(int height, int width) {
            char[,] pyramid = new char[height, width];
            //some code to make it work, good luck 
            
            return pyramid;
        }

        // takes 2 int arrays, returns the elements from the first array that aren't in the 
        // second array
        public int[] Different(int[] arr1, int[] arr2) {

            return new int[] { };
        }

        // Using DateTime and AddDays increment the given date by one year
        public string AddAYear(int year, int month, int day)
        {
            return "";
        }
        // An Array of integers are provided theyre in a random order
        // create a method that will sort this array in an acsending order
        public int[] BubSort(int[] unsorted)
        {
            return new int[] { };
        }

        // Create a method that will write the string "Hello" reversed
        public string ReverseString(string str)
        {
            return str;
        }

        //solve 3x^2 + 2x - 1, one of the roots will be the correct answer
        public double Quadratic(int a, int b, int c)
        {
            return 0;
        }
        // get 5th letter from the words inputted not including spaces
        //if there aren't 5 letters return a whitespace char ' '
        public char FifthLetter(string test)
        {
            return ' ';
        }
        // create a loop, return the sum of all the multiples of 4. Also use out the sum of all that is not the multiple of 6.
        // return the sum of all of the multiples of 4, which aren't multiples of 6, up to the inputted number,
        public int SumOfFours(int test)
        {
            return -1;
        }
        // return true is the 4 characters make up a string that match a name in the array given
        public bool NameReturn(char a, char b, char c, char d)
        {
            bool isName = false;
            string[] names = new string[] { "chad", "jess", "adam" };
            
            return isName;
        }
        // Find the smallest integer in an array of integers
        public int Smallest(int[] intArray)
        {
            //Code here
            return -1;
        }

        // given a positive integer that is a squared number
        // find the next squared number eg 9 => 16
        public int NextSquare(int n)
        {
            // Code here
            return -1;
        }
        // Calculate the nth term in a geometric series , a_n
        // a_1 is the first term, r is the common ratio and n is the number of terms
        // Remember the first term a_1 is already given, that is, n = 1
        // Give your answer to 2d.p.
        public double GeometricSeries(int a_1, double r, int n)
        {
            // Code here
            return -1;
        }

        //Roman Encyption shift each letter in the string up by 13, it is still csae sensitive
        // "Hello" would become "Uryyb"
        public string RomanEncryption(string messge)
        {
            string code = "";
            return code;
        }

        //Decrypt the roman message
        //"Uryyb" would become "Hello"
        public string RomanDecryption(string code) {
            string message = "";
            return message;
        }

        // summation between the 2 numbers including numbers inputed given Sum(0,3) => 6 and Sum(3,-1) => 5
        public int Sum(int a, int b)
        {
            return -1;
        }
    }
}
