using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_30_queue
{
    class Program
    {
        static Queue<int> queue01 = new Queue<int>();

        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                queue01.Enqueue(i * 10);
            }

            Console.WriteLine($"This contains the item 50? " +
                $"{queue01.Contains(50)}");
            Console.WriteLine("Display full queue first before we begin");
            foreach (int item in queue01)
            {
                Console.WriteLine(item);
            }
            // dequeue 3 items
            queue01.Dequeue();
            queue01.Dequeue();
            queue01.Dequeue();
            foreach(int item in queue01)
            {
                Console.WriteLine(item);
            }
        }
    }
}
