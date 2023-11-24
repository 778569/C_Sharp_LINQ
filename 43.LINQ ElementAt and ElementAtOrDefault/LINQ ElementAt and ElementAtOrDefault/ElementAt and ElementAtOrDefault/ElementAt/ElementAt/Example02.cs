using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementAt
{
    public class Example02
    {
        public void Test()
        {
            Student ElementAtMS = Student.GetAllStudents().ElementAt(0);

            Student ElementAtQS = (from student in Student.GetAllStudents()
                                  select student).ElementAt(2);


            Student ElementAtOrDefaultMS = Student.GetAllStudents().ElementAtOrDefault(0);

            Student ElementAtOrDefaultQS = (from student in Student.GetAllStudents()
                                            select student).ElementAtOrDefault(3);


            Console.WriteLine($"ID: {ElementAtMS.ID}, Name: {ElementAtMS.Name}, Department: {ElementAtMS.Department}");
        }
    }
}
