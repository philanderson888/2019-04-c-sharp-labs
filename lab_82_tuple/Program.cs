using System;

namespace lab_82_tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis();
            Console.WriteLine($"AlsoDoThis = {AlsoDoThis()}");

            int output = AndThis(out string y);

            Console.WriteLine($"AndThis : {output,-10}{y}");

            var output2 = TupleThis();
            Console.WriteLine(output2.Item1);
            Console.WriteLine(output2.Item2);

            var output3 = TupleThisAlso();
            Console.WriteLine(output3.NumberA);
            Console.WriteLine(output3.StringB);

            
            var output4 = null ?? "hi";         // returns  hi
            var output5 = "data" ?? "hi";       // returns  data


            var dataFromDatabase = "some data";
            var output6 = dataFromDatabase ?? "default value";
            // if data is null, will assign default value
        }

        static (int NumberA, string StringB) TupleThisAlso()
        {
            return (33, "more text");
        }

        static Tuple<int,int> AndThis()
        {
            return new Tuple<int, int>(100, 100);
        }


        static void DoThis() {
            Console.WriteLine("I am doing nothing");
        }

        static int AlsoDoThis()
        {
            return -1;
        }

        static int AndThis(out string y)
        {
            y = "returning this string";
            return -100;
        }

        static (int,string) TupleThis()
        {
            return (22, "and some text");
        }



    }
}
