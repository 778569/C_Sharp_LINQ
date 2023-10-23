using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Distinct_Method
{
    public class Example02
    {

        public void Test()
        {
            string[] namesArray = { "Priyanka", "HINA", "hina", "Anurag", "Anurag", "ABC", "abc" };

            // Ignore Case Sensitive

            var IgnoreCaseSen = namesArray.Distinct(StringComparer.OrdinalIgnoreCase).ToList();

            foreach (var name in IgnoreCaseSen)
            {
                Console.WriteLine(name);
            }







            //var distinctNames = namesArray.Distinct();

            //foreach (var name in distinctNames)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
