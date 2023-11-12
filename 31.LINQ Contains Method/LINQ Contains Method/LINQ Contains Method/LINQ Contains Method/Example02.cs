using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Contains_Method
{
    public class Example02
    {
        public void Test()
        {
            List<Student> students = new List<Student>();

            var student01 = new Student() { ID = 101, Name = "Buddhika", TotalMarks = 275 };

            var student2 = new Student() { ID = 102, Name = "Kavinda", TotalMarks = 375 };

            students.Add(student01);
            students.Add(student2);

            var IsExistsMS = students.Contains(student01);

            var IsExistsQS = (from stu in students
                             select stu).Contains(student01);

            Console.WriteLine(IsExistsMS);

            Console.WriteLine(IsExistsQS);
        }
    }
}
