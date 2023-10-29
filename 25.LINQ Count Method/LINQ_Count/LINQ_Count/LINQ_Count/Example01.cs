using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Count
{
    public class Example01
    {

        public void Test()
        {
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //Using Method Syntax
            int MSCount = intNumbers.Where(num => num > 40).Count();
            //Using Query Syntax
            var QSCount = (from num in intNumbers
                           where num > 40
                           select num).Count();
            Console.WriteLine("No of Elements = " + MSCount);

        }
    }
}
