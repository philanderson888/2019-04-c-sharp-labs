using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_63_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruit.banana);
            // use the numeric value also
            Console.WriteLine((int)Fruit.banana);
            // even add a count 
            Console.WriteLine($"There are {(int)Fruit.count} types of fruit");
            // add an invalid type with -1
            // Common example is days of week & months of year
            var d = DateTime.Now;
            Console.WriteLine(d.Month);
            Console.WriteLine(d.Day);
            Console.WriteLine((int)d.DayOfWeek);
            d = d.AddDays(-2);
            Console.WriteLine((int)d.DayOfWeek);
            d = d.AddDays(-1);
            Console.WriteLine((int)d.DayOfWeek);

            var fruityfruit = Fruit.plum;
        }
    }

    // Enum is a structure to hold values which are not expected to 
    // change , ever
    // days of week or months of year or staff codes in a company
    enum Fruit
    {
        invalid=-1,banana,apple=1,pear=2,plum,peach,grape,count
    }
}
