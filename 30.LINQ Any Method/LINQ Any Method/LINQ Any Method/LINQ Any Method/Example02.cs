using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Any_Method
{
    public class Example02
    {
        public void Test()
        {
            var ResultMS = Student.GetAllStudnets().Any(x=>x.TotalMarks > 250);

            var ResultQS = (from stu in Student.GetAllStudnets()
                            select stu).Any(x=>x.TotalMarks < 100);

            Console.WriteLine($"Any Student Having Total Marks > 250: {ResultMS}");

            Console.WriteLine($"Any Student Having Total Marks < 100: {ResultQS}");
        }


        public void ComplexType()
        {

            var ResultMS = Student.GetAllStudnets().Where(x => x.Subjects.Any(marks => marks.Marks > 90)).ToList();

            foreach (var student in ResultMS)
            {

                Console.WriteLine($"{student.Name} - {student.TotalMarks}");
                foreach (var subject in student.Subjects)
                {
                    Console.WriteLine($" {subject.SubjectName} - {subject.Marks}");
                }

            }

        }
    }
}
