using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skip_Method
{
    public class Example01
    {
        public void Test()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.Skip(4).ToList();

            List<int> ResultQS = (from num in numbers
                                 select num).Skip(4).ToList();  

            foreach (var item in ResultMS)
            {
                Console.Write(item + " ");
            }
        }

        public void Test2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.Where(num=>num>3).Skip(4).ToList();

            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Skip(4).ToList();


            foreach (var item in ResultMS)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in ResultQS)
            {
                Console.Write(item + " ");
            }
        }
        public void Test3()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            var ResultMS = numbers.Skip(4).Where(num => num >6 ).ToList();

            var ResultQS = (from num in numbers select num).Skip(4).Where(num => num > 6);


            foreach (var item in ResultMS)
            {
                Console.Write(item + " ");
            }
        }
    }
}
