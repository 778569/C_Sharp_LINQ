using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementAt
{
    public class Example01
    {
        public void Test()
        {
            List<int> numbers = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int MethodSyntax = numbers.ElementAt(0);

            int QuerySyntax = (from num in numbers select num).ElementAt(1);

            Console.WriteLine();
            Console.WriteLine(MethodSyntax);
            

        }
    }
}
