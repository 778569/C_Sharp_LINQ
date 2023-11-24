using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Cross_Join
{
    public class Example01
    {
        public void Test()
        {
            var CrossJoinResult = from stu in Student.GetAllStudents()
                                  from subj in Subject.GetAllSubjects()
                                  select new
                                  {
                                      StudentName = stu.Name,
                                      SubjectName = subj.SubjectName
                                  };

            foreach (var item in CrossJoinResult)
            {
                Console.WriteLine($"Name : {item.StudentName}, Subject: {item.SubjectName}");
            }
        }

        public void Test2()
        {
            var CrossJointResult = Student.GetAllStudents().SelectMany(sub => Subject.GetAllSubjects(), (std, sub) => new
            {
                StudentName = std.Name,
                SubjectName = sub.SubjectName

            });
            var CrossJoinResult2 = Student.GetAllStudents()
                        .Join(Subject.GetAllSubjects(),
                            std => true,
                            sub => true,
                            (std, sub) => new
                            {
                                StudentName = std.Name,
                                SubjectName = sub.SubjectName
                            }
                         );

            foreach (var item in CrossJoinResult2)
            {
                Console.WriteLine($"Name : {item.StudentName}, Subject: {item.SubjectName}");
            }
        }
    }
}
