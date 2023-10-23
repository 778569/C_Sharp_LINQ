using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Distinct_Method
{
    public class ComplexType
    {
        public void Test()
        {
            var MethodSyntax = Student.GetStudent().Select(x => x.Name).Distinct().ToList();



            var QuerrySyntax = (from stu in Student.GetStudent()
                                select stu.Name).Distinct().ToList();


            //Console.WriteLine(MethodSyntax);      

            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }
        }


        public void Test2()
        {
            var MS = Student.GetStudent().Distinct().ToList();

            var QS = (from stud in Student.GetStudent() select stud.Name).Distinct().ToList();

            foreach (var item in MS)
            {
                Console.Write(item.ID + " ");
                Console.Write(item.Name);
                Console.WriteLine();
            }

        }


        public void Test3()
        {

            var MS = Student.GetStudent().Select(std => new { std.ID, std.Name }).Distinct().ToList();

            var QS = (from stu in Student.GetStudent()
                      select new { stu.ID, stu.Name }).Distinct().ToList();

            foreach (var item in QS)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }
        }
    }
}
