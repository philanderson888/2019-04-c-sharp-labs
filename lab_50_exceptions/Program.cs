using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_50_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                // something can go wrong here
            }
            catch(Exception e) {
                // process the 'exception' ie 'handle it'
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }
            finally {
                // always do this code regardless if exception or not
            }

            // divide by zero
            int x = 10, y = 0;



            try {
                int z = x / y;
            }

            // catch divide by zero exception only
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error - division by zero");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
                System.IO.File.WriteAllText("errorlog.txt", "major malfunction" + DateTime.Now);
            }
            // catch every exception of all types
            catch (Exception e) {
                Console.WriteLine("OOPS! SNAP! Something went wrong!");
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("but program is still working");
            }

            Console.WriteLine("Program still works here");
        }
    }
}
