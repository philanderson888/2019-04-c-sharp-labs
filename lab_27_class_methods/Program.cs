using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_27_class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var car01 = new Mercedes();
            car01.Speed = 10;
            // pass in old and get out new speed
            var increasedSpeed = car01.Accelerate(car01.Speed);
            Console.WriteLine(increasedSpeed);  // should be 11
            increasedSpeed = car01.Accelerate(car01.Speed); // 12
            increasedSpeed = car01.Accelerate(car01.Speed); // 13
            increasedSpeed = car01.Accelerate(car01.Speed); // 14
            Console.WriteLine(increasedSpeed);  // should be 14
        }
    }

    class Mercedes
    {
        public int Speed;

        public int Accelerate(int oldSpeed)
        {
            oldSpeed++;
            Speed = oldSpeed;
            return Speed;
        }
    }
}
