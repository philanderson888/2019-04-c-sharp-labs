using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phil1;

namespace lab_06_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new phil1.GreatTrainer();
            // add using statement, can see directly
            var item2 = new GreatTrainer();

            var item3 = new phil2.ExcellentLearning();
            Console.WriteLine(item3.LearnLots);
        }
    }
}

namespace phil1 {
    public class GreatTrainer { }
}

namespace phil2 {
    public class ExcellentLearning {
        public string LearnLots = "running C#";
    }
}

