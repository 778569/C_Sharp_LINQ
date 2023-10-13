using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_LINQ_Query
{
    public class LINQ_Test
    {

        public void Test()
        {

            //Data Source
            List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Query



            var QuerySyntax = (from obj in integerList
                               where obj > 5
                               select obj).Sum();




            Console.WriteLine($"Sum is : {QuerySyntax}");





            


            //var QuerySyntax = integerList.Where(x=>x > 5).ToList();

            //foreach (var item in QuerySyntax)
            //{
            //    Console.WriteLine(item);
            //}










            //var QuerySyntax = from obj in integerList // Dats Source
            //                  where obj > 5  // Condition
            //                  select obj;   // Selection


            //foreach (var item in QuerySyntax)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
