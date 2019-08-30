using System;
using System.IO;

namespace lab_86_async_await_streaming
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
            for(int i = 0; i < 500; i++)
            {
                File.AppendAllText("file.txt", DateTime.Now.ToString() +"\n");
            }

            // Asynchronous method can take a long time
            ReadFileAsync();
            Console.WriteLine("Program Has Finished");
            Console.ReadLine();
        }

        static async void ReadFileAsync()
        {
            // just for illustration
            // string output = await File.ReadAllTextAsync("file.txt");
            // Console.WriteLine(output);


            // use StreamReader
            string oneLine;
            using (var reader = new StreamReader("file.txt"))
            {
                while (true)
                {
                    oneLine = await reader.ReadLineAsync();
                    if (oneLine == null) break;
                    Console.WriteLine(oneLine);
                }
            }


        }
    }
}
