using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Method
{
    public class TakeExample01
    {
        public void Test()
        {
            List<int> numbers = new List<int> (){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.Take(4).ToList();

            List<int> ResultQS = (from num in numbers
                                  select num).Take(4).ToList();

            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void Test1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.Where(x=>x>3).Take(4).ToList();

            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Take(4).ToList();

            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void Test2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.Take(4).Where(x=>x >= 3).ToList();

            List<int> ResultQS = (from num in numbers
                                 select num).Where(x=>x>=3).ToList();

            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
