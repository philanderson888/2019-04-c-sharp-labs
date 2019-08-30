using System;
using lab_04_dll;

namespace lab_05_use_dll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading from another library");
            var item = new PhilLibrary();
            item.PhilsData = "some data here";
            Console.WriteLine(item.PhilsData);
            Console.WriteLine(item.PhilsFixedData);
        }
    }
}
