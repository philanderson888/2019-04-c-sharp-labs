using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_45_file_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new file from scratch
            File.WriteAllText("file.txt", "some data");
            

            // Read 1 line of text as a string
            Console.WriteLine("\n\nRead raw data");
            string data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            // Write data
            Console.WriteLine("\n\nwriting new text");
            File.WriteAllText("file.txt", "here is some new data",Encoding.UTF8);

            Console.WriteLine("\n\nreading text back again");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            // append : adds at end
            Console.WriteLine("\n\nAppending Text");
            File.AppendAllText("file.txt", "\nand here is some more data 2 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nand here is some more data 3 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nand here is some more data 4 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nand here is some more data 5 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nand here is some more data 6 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nsearchterm22");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            // data logging : used all the time - add a DateTime.Now
            Console.WriteLine("\n\nLogging With DateTime Stamp");
            File.AppendAllText("file.txt", Environment.NewLine + DateTime.Now);
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);




            // reading multiple lines to an array
            Console.WriteLine("\n\nSearching text file for a term");
            string[] dataArray = File.ReadAllLines("file.txt"); 
            foreach(string item in dataArray){
                if (item == "searchterm22")
                {
                    Console.WriteLine("Bingo ! searchterm22 has been found!!!" );
                }
            }
            for(int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] == "searchterm22")
                {
                    Console.WriteLine($"Bingo!  searchterm22 found at line {i}");
                }
            }


            // File.Copy   (true means yes overwrite 
            // if exists already)
            File.Copy("file.txt", "filecopy.txt", true);

            File.Delete("file.txt");
            File.Delete("filecopynewname.txt");

            if (!File.Exists("filecopynewname.txt")){
                File.Move("filecopy.txt", "filecopynewname.txt");
            }

            Console.WriteLine(File.GetCreationTime("filecopy.txt"));
            Console.WriteLine(File.GetLastWriteTime("filecopy.txt"));


            // folders
            // create folder
            Directory.CreateDirectory("Parent");
            Directory.CreateDirectory("Parent\\Child1");
            Directory.CreateDirectory("Parent\\Child2");
            Directory.CreateDirectory("Parent\\Child3");
            File.WriteAllText("Parent//Child3//file.txt", "hello");
            File.WriteAllText($"Parent/Child3/file2.txt", "hello");
            // delete one
            Directory.Delete("Parent/Child2", true);
            // create in C:\ drive
            Directory.CreateDirectory("/TestFolder");
            
            // create in MyDocuments
            Directory.CreateDirectory(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 
                + "/TestFolder");

            // list all files in folder and see if one file exists!!!
            /* lab : 
             *      create folder in My Documents
             *      create 3 text files 
             *      create an array called FileList
             *      put the names of the text files into this array
             *      check if "BobsFile.txt" is one of your files!
             *      return true if it is
             * 
            */
                

        }
    }
}
