using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    public class SingleExample01
    {

        public void Test()
        {
            List<int> numbers = new List<int>() { 10 };

            var MS = numbers.Single();

            var QS = (from num in numbers
                      select num).Single();

            Console.WriteLine(MS);
        }

        public void Test1()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 }; ;


            var MS = numbers.Single();

            var QS = (from num in numbers
                      select num).Single();

            Console.WriteLine(MS);
        }
        public void Test2()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 }; ;


            var MS = numbers.Single(x=>x == 10);

            var QS = (from num in numbers
                      select num).Single(x => x == 20);

            Console.WriteLine(MS);
        }

        public void Test3()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 }; ;


            var MS = numbers.Single(x => x > 10);

            var QS = (from num in numbers
                      select num).Single(x => x > 20);

            Console.WriteLine(MS);
        }
    }
}
