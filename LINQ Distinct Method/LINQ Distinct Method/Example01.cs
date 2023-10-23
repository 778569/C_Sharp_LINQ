using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Distinct_Method
{
    public class Example01
    {
        public void Test()
        {

            List<int> intCollection = new List<int>()
            {
                1,2,3,2,3,4,4,5,6,3,4,5
            };

            var MethodSyntax = intCollection.Distinct().ToList();

            var QueerySyntax = (from num in intCollection
                                select num).Distinct();

            foreach (var item in MethodSyntax)
            {
                Console.Write(item + " ");
            }
        }
    }
}
