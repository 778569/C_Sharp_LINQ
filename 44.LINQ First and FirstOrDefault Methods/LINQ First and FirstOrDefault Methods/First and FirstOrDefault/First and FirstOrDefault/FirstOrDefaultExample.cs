using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_FirstOrDefault
{
    public class FirstOrDefaultExample
    {
        public void Test()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int MethodSyntax = numbers.FirstOrDefault(num => num > 5);

            int QuerySyntax = (from num in numbers
                               select num).FirstOrDefault(num => num > 5);

            Console.WriteLine(MethodSyntax);

            //int MethodSyntax = numbers.FirstOrDefault();

            //int QuerySyntax = (from num in numbers
            //                  select num).FirstOrDefault();

            //Console.WriteLine(MethodSyntax);
        }
    }
}
