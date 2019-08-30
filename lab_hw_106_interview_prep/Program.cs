using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_hw_106_interview_prep;

namespace lab_hw_106_interview_prep
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ASCII
    {
        // Goal : Return ASCII number of character sent in
        // Input a string eg "hello" and an index eg 3
        // Return ASCII number of letter 'l'
        public int ASCII_Return_Index_Of_String(string input, int index)
        {
            // a string is already a char array 
            char[] charArray = input.ToCharArray();
            var selectedChar = charArray[index];
            var ASCIIcode = (int)selectedChar;
            return ASCIIcode;
        }
    }

    public class ThrowException
    {
        public int Throw_Exception_Test(int x, int y)
        {
            int output = 0;
            checked
            {
                output = x * y;
              
            }
            return output;
        }
    }



}
