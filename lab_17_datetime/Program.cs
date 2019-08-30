using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_17_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare date
            // not very helpful : default date is 1 Jan 0001 at midnight
            var d = new DateTime();


            Console.WriteLine(d);

            var e = DateTime.Today;   // midnight 
            var f = DateTime.Now;     // now


            Console.WriteLine(e);
            Console.WriteLine(f);

            // add calendar day/week/month
            e = e.AddDays(1);
            e = e.AddMonths(1);
            e = e.AddHours(1);

            Console.WriteLine(e);

            // elapsed time
            // use seconds, milliseconds, ticks (10-7 seconds ie 100 nanoseconds!)

            // CRUDE : SUBTRACTING TIME
            var start = DateTime.Now;

            int total = 0;

            for(int i = 0; i < 100000000; i++)
            {
                total += i;
            }

            Console.WriteLine(total);

            var stop = DateTime.Now;

            Console.WriteLine($"Counting took {(stop - start)}");
            Console.WriteLine($"Counting took {(stop - start).Milliseconds}");
            Console.WriteLine($"Counting took {(stop - start).Ticks}");


            // EASY WAY : CREATE 'STOPWATCH'

            var s = new Stopwatch();
            s.Start();

            total = 0;

            for (int i = 0; i < 100000000; i++)
            {
                total += i;
            }

            s.Stop();
            Console.WriteLine(s.ElapsedTicks);
            Console.WriteLine(s.Elapsed);

        }
    }
}
