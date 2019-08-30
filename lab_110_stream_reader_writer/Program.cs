using System;

namespace lab_110_stream_reader_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Stream_Reader_Writer
    {
        public static (int,string) Stream_Reader_Writer_Parse(string path)
        {
            // Get path of a file
            // Use StreamReader to read the file
            int numlines = -1; // number of lines in the file
            string output = "-1";  //  output string 

            // parse each string as you read it in and remove all spaces
            // (leading, trailing and in the middle);
            // return the raw string as one long string
            // eg
            //  text file is 
            /*
             *   hello how are
             *   you ? I am very
             *   
             *   
             */
             // returns (2,"hellohowareyou?Iamvery")

            return (numlines, output);  // Tuple!
        }

        // create a method to input an array of strings.  
        // from this array create a text file
        // path will be passed in 
        // use streamwriter to write the array of strings into the text file.
        // test by using the same logic used in the 
        //  public static (int,string) Stream_Reader_Writer_Parse(string path) 
        // method above

         
    }
}


