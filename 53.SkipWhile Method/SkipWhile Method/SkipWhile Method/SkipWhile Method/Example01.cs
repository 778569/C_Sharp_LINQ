using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipWhile_Method
{
    public class Example01
    {
        public void Test()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.SkipWhile(x => x < 3).ToList();

            List<int> ResultQS = (from num in numbers
                                 select num).SkipWhile(x => x < 3).ToList();

            Console.Write(string.Join(", ", ResultMS));


            //foreach (var item in ResultMS)
            //{
            //    Console.Write(string.Join(", ", item));
            //}
        }
        public void Test2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.SkipWhile(x => x < 3).ToList();

            foreach (var item in ResultMS)
            {
                // Convert the integer item to a string before using string.Join
                Console.Write(string.Join(", ", ResultMS));
            }
        }

        public void Test3()
        {

            List<string> names = new List<string>() { "Pam", "Rahul", "Kim", "Sara", "Priyanka" };

            List<string> ResultMS = names.SkipWhile(str => str.Length < 4).ToList();


            Console.Write(string.Join(", ", ResultMS));

        }

    }
}
