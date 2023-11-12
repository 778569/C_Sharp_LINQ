using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_All_Method
{
    public class Example02
    {

        public void Test()
        {
            var MS = Student.GetAllStudent().All(x => x.TotalMarks >= 250);

            Console.WriteLine($"Is All Students Having Total Marks 250: {MS}");

            var QS = (from stu in Student.GetAllStudent() select stu).All(marks => marks.TotalMarks < 300);

            Console.WriteLine($"Is All Students Having Less than Total Marks 300: {QS}");
        }

        public void Test1()
        {
            var MS = Student.GetAllStudent().Where(stu => stu.Subjects.All(x => x.Marks > 80)).ToList(); ;

            var QS = (from stu in Student.GetAllStudent()
                      where stu.Subjects.All(x => x.Marks > 80)
                      select stu).ToList();

            foreach (var student in MS)
            {
                Console.WriteLine($"{student.Name} - {student.TotalMarks}");
                
                foreach (var subject in student.Subjects)
                {
                    Console.WriteLine($" {subject.SubjectName} - {subject.Marks}");
                }
                Console.WriteLine();
            }
        }
    }
}
