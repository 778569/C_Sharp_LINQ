using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEqual_Method
{
    public class ComplexTypeEx01
    {

        public void Test()
        {
            List<Student> StudentList1 = Student.GetStudents1();
            List<Student> StudentList2 = Student.GetStudents2();

            bool IsEqualMS = StudentList1.Equals(StudentList2);

            bool IsEqualQS = (from stu in StudentList1
                             select stu).SequenceEqual(StudentList2);

            Console.WriteLine(IsEqualMS);

        }

        public void Test1()
        {
            //Collection 1 or Sequenece 1
            List<Student> StudentList1 = Student.GetStudents1();
            //Collection 1 or Sequenece 1
            List<Student> StudentList2 = Student.GetStudents2();

            bool IsEqualMS = StudentList1.Select(std => new
            {
                std.ID,
                std.Name
            }).SequenceEqual(StudentList2.Select(stu => new
            {
                stu.ID,
                stu.Name
            }));

            bool IsEqualQS = (from stu in StudentList1
                              select new
                              {
                                  stu.ID,
                                  stu.Name
                              }).SequenceEqual(StudentList2.Select(stu => new
                              {
                                  stu.ID,
                                  stu.Name
                              }));

            Console.WriteLine(IsEqualMS);
        }

    }
}
