using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SelectMany_Method
{
    public class SelectMany_Method
    {

        public void Test()
        {

            //List<string> nameList = new List<string>() 
            //{

            //"Kavinda",
            //"Buddhika"

            //};

            ////IEnumerable<char> methodSyn = nameList.SelectMany(x=>x);

            //IEnumerable<char> methodSyn = from Name in nameList 
            //                              from Che in Name
            //                              select Che;

            //foreach (var item in methodSyn)
            //{
            //    Console.Write(item + " ");
            //}





            //List<string> MethodSyntax = Student.GetStudents().SelectMany(p=> p.Programming).ToList();


            //foreach (var item in MethodSyntax)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine( );

            //IEnumerable<string> Query = (from std in Student.GetStudents()
            //                             from pro in std.Programming
            //                            select pro).Distinct().ToList();


            //foreach (var item in Query)
            //{
            //    Console.Write(item + " ");
            //}



            /*
             
             
           The Distinct() method will remove duplicate elements from the source collection and return a new sequence with only the unique elements. It does so by comparing elements for equality based on their default equality comparer, which is determined by the element type. If you want to use a custom equality comparison, you can provide an IEqualityComparer<T> as an argument to the Distinct() method.
             
             
             */


            // Method Syntax
            var QryStu = Student.GetStudents().SelectMany(x => x.Programming, y=> y.ID ,(student, progrm, Id) => new
            {
               StudenName = student.Name,
               Pro = progrm,
               Id = Id

            }).ToList();


            foreach (var item in QryStu)
            {
                Console.WriteLine(item.StudenName + "=>" + item.Pro +"=>"+ );
            }

            //Query Syntax


            var QSyantax = (from pro in Student.GetStudents()
                           from programming in pro.Programming
                           select new
                           {
                               StudentName = pro.Name,
                               Programming = programming
                           }).ToList();
           
        }
    }
}
