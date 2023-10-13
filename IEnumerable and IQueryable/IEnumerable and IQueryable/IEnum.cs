using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_and_IQueryable
{
    public class IEnum
    {
        public void Test()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Gender = "Male"},
                new Student(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            IEnumerable<Student> students = from std in studentList
                                            where std.Gender == "Male"
                                            select std;

            IQueryable<Student> students1 = (IQueryable<Student>)(from std in studentList // Should Add cast
                                            where std.Gender == "Male"
                                            select std);

            foreach (var item in students)
            {
                Console.WriteLine("ID = {0} , Name = {1}, Gender = {2}",item.ID , item.Name, item.Gender);
            }
        }
    }
}
