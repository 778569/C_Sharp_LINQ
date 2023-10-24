using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OrderBy_Method
{
    public class Complex_Type
    {

        public void Test()
        {

            var MS = Student.GetAllStudents().OrderBy(x => x.Branch).ToList();

            var QS = (from stu in Student.GetAllStudents()
                     orderby stu.Branch
                     select stu).ToList();

            foreach (var student in MS)
            {
                Console.WriteLine(" Branch: " + student.Branch + ", Name :" + student.FirstName + " " + student.LastName);
            }


        }

        public void Test2() 
        {

            var MS = Student.GetAllStudents().Where(std => std.Branch.ToUpper() == "CSE").OrderBy(x => x.FirstName).ToList();

            var QS = (from stu in Student.GetAllStudents()
                      where stu.Branch.ToUpper() == "CSE"
                      orderby stu.FirstName
                      select stu).ToList();


            foreach (var student in MS)
            {
                Console.WriteLine(" Branch: " + student.Branch + ", Name :" + student.FirstName + " " + student.LastName);
            }

        }
    }
}
