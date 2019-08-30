using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_81_EF6_update_database
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            using (var db = new StudentDbEntities())
            {
                students = db.Students.ToList();
            }
            students.ForEach(s => {

                Console.WriteLine(s.FirstName);
                Console.WriteLine(s.DateOfBirth);
                
                });
        }
    }
}
