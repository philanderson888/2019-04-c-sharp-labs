using System;
using System.IO;
using System.Text;
using static System.Console;

namespace lab_85_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "Some", "data", "here" };
            File.WriteAllLines("file.txt", data);
            File.AppendAllLines("file.txt", data);
            File.AppendAllText("file.txt", "and some extra data here\n");
            File.AppendAllText("file.txt", DateTime.Now.ToString());

            // Several ways to read a file and determine
            // file has been read
                       
            var reader01 = new StreamReader("file.txt");

            // variable to hold data while being read in
            string output = null;

            // two things at once
            // first++++ reading the next line of output => string
            // checking that this line is not null
            WriteLine("\n\nTesting For Output Not Null");
            while ((output = reader01.ReadLine())  != null)
            {
                WriteLine(output);
            }

            // Second way of determining end of file has been reached
            WriteLine("\n\nTesting For End Of Stream reached");
            var reader02 = new StreamReader("file.txt");
            while (!reader02.EndOfStream)
            {
                Console.WriteLine(reader02.ReadLine());
            }
        }
    }
}
