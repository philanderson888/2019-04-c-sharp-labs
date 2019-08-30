using System;
using System.Collections.Generic;

namespace lab_hw_103_loops
{
    class Program
    {


        static void Main(string[] args)
        {
            
            var instance = new CollectionsLab();
            Console.WriteLine(instance.Collections(10, 20, 30));
        }

        class CollectionsLab
        {
            static int[] array;
            static Queue<int> queue = new Queue<int>();
            static List<int> list = new List<int>();
            static Stack<int> stack = new Stack<int>();
            static Dictionary<int, int> dictionary = new Dictionary<int, int>();

            public int Collections(int a, int b, int c)
            {
                array = new int[3] { a, b, c };
                foreach(int item in array)
                {
                    queue.Enqueue(item * 2);
                }
                while (queue.Count > 0)
                {
                    list.Add(queue.Dequeue()*2);
                }
                foreach(int item in list)
                {
                    stack.Push(item * 2);
                }
                for (int i = 0; i < 3; i++)
                {
                    dictionary[i] = stack.Pop() * 2;
                }
                var total = 0;
                foreach(var key in dictionary.Keys)
                {
                    total += dictionary[key];
                }
                return total;
            }

        }

    }
}
