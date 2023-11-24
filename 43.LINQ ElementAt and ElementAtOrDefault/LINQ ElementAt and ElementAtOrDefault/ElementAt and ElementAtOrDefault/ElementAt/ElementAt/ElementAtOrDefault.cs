using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementAt
{
    public class ElementAtOrDefault
    {
        public void Test()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int MethodSyntax1 = numbers.ElementAtOrDefault(10);

            int MethodSyntax2 = numbers.ElementAtOrDefault(-1);

            Console.WriteLine($"Value at Index Position 10: {MethodSyntax1}");
            Console.WriteLine();
            Console.WriteLine($"Value at Index Position 10: {MethodSyntax2}");


            //int MethodSyntax = numbers.ElementAtOrDefault(0);

            //int QuerySyntax = (from num in numbers
            //                   select num).ElementAtOrDefault(1);

            //Console.WriteLine(MethodSyntax);
        }
    }
}
