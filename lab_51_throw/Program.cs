using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_51_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                var output = TryThis();
                if (output == -1){
                    throw new Exception("Hey something really badly went wrong");
                }
            }
            catch (Exception e){ 
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("But program still works!");
            }
        }

        static int TryThis()
        {
            return -1;
        }
    }
}
