using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultIfEmpty
{
    public class Example01
    {


        public void Test()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };

            var MS = numbers.DefaultIfEmpty();

            IEnumerable<int> QS = (from num in numbers
                                  select num).DefaultIfEmpty();

            foreach (var num in MS)
            {
                Console.WriteLine($"{num} ");
            }
        }
        public void Test1()
        {
            List<int> numbers = new List<int>();

            var MS = numbers.DefaultIfEmpty();

            IEnumerable<int> QS = (from num in numbers
                                   select num).DefaultIfEmpty();

            foreach (var num in MS)
            {
                Console.WriteLine($"{num} ");
            }
        }

        public void Test2()
        {
            List<int> numbers = new List<int>();

            var MS = numbers.DefaultIfEmpty(5);

            IEnumerable<int> QS = (from num in numbers
                                   select num).DefaultIfEmpty();

            foreach (var num in MS)
            {
                Console.WriteLine($"{num} ");
            }
        }
        public void Test3()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };

            var MS = numbers.DefaultIfEmpty(5);

            IEnumerable<int> QS = (from num in numbers
                                   select num).DefaultIfEmpty();

            foreach (var num in MS)
            {
                Console.WriteLine($"{num} ");
            }
        }
    }
}
