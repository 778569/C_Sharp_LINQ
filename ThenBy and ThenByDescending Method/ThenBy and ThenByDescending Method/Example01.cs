using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThenBy_and_ThenByDescending_Method
{
    public class Example01
    {

        public void Test()
        {
            var MS = Student.GetAllStudents()
                .OrderBy(name=> name.FirstName)
                .ThenBy(name=>name.LastName).ToList();

            var QS =  (from stu in Student.GetAllStudents()
                      orderby stu.FirstName, stu.LastName
                      select stu).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine("First Name : " + item.FirstName + " " + " Last Name : " + item.LastName);
                
            }

        }


        public void Test2()
        {
            var MS = Student.GetAllStudents().OrderBy(branch => branch.Branch).ThenByDescending(FN => FN.FirstName).ThenBy(LN => LN.LastName);

            var QS = (from stu in Student.GetAllStudents()
                      orderby stu.Branch ascending,
                              stu.FirstName descending,
                              stu.LastName
                      select stu).ToList();

            foreach (var student in MS)
            {
                Console.WriteLine("Barnch " + student.Branch + ", First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            }



        }


        public void Test3()
        {

            var MS = Student.GetAllStudents().Where(stu => stu.Branch == "CSE").OrderBy(x => x.FirstName).ThenByDescending(y => y.LastName).ToList();

            var QS = (from stu in Student.GetAllStudents()
                      where stu.Branch == "CSE"
                      orderby stu.FirstName ascending,
                              stu.LastName descending
                      select stu).ToList();


            foreach (var student in QS)
            {
                Console.WriteLine("Barnch " + student.Branch + ", First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            }

        }
    }
}
