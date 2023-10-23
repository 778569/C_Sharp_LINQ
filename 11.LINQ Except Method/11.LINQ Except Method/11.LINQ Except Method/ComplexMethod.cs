using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _11.LINQ_Except_Method
{
    public class ComplexMethod
    {

        public void Test()
        {

            List<Student> AllStudents = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
                new Student {ID = 106, Name = "Santosh"},
            };
            List<Student> Class6Students = new List<Student>()
            {
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
            };



            var MQ = AllStudents.Select(x => new { x.ID, x.Name }).Except(Class6Students.Select(y => new { y.ID, y.Name })).ToList();


            foreach (var student in MQ)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }


            //var studentsMQ = AllStudents.Select(x => x.Name).Except(Class6Students.Select(y => y.Name)).ToList();


            //foreach (var item in studentsMQ)
            //{
            //    Console.WriteLine(item);
            //}


            //var studentsQS = (from stu in AllStudents
            //                  select stu.Name).Except(Class6Students.Select(y => y.Name)).ToList();

        }
    }
}
