using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_29_collections
{
    class Program
    {
        static List<int> list01 = new List<int>();
        List<string> list02 = new List<string>();
        static Stack<int> stack01 = new Stack<int>();

        static void Main(string[] args)
        {
            list01.Add(10);
            list01.Add(20);
            foreach (var item in list01) {
                Console.WriteLine(item);
            }
            // Shorthand 'lambda' or 'arrow' syntax for a loop
            list01.ForEach(item => Console.WriteLine(item));



            DoThis();
            stack01.Push(10);  //BOTTOM
            stack01.Push(20);  // MIDDLE
            stack01.Push(30);  // TOP
            Console.WriteLine(stack01.Contains(30));  //true
            Console.WriteLine(stack01.Pop());  // yield 30 and remove
            foreach(int item in stack01)
            {
                Console.WriteLine(item);
            }
            // peek at top item which is 20 now
            Console.WriteLine($"Top item is {stack01.Peek()}");
            // add 2 more items
            stack01.Push(50);
            stack01.Push(60);
            // use every item in stack
            Console.WriteLine("using every item from stack");
            while (stack01.Count > 0)
            {
                Console.WriteLine(stack01.Pop());
            }

            
        }

        static void DoThis()
        {
            int x = 20;
            int y = 10;
            DoThat();

        }

        static void DoThat()
        {
            int z = 30;
        }
    }
}
