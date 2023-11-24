using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TakeWhile_Method
{
    public class TakeWhileExample
    {
        public void Test()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.TakeWhile(x=>x < 6).ToList();

            List<int> ResultQS = (from num in numbers
                                 select num).TakeWhile(x=>x < 6).ToList();

            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }
        public void Test1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.Where(x=>x < 6).ToList();

            List<int> ResultQS = (from num in numbers
                                  where num < 6
                                  select num).ToList();


            foreach (var num in ResultQS)
            {
                Console.Write($"{num} ");
            }
        }

        public void Test2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };

            List<int> ResultMS = numbers.TakeWhile(num=> num < 6).ToList();

            Console.Write("Result Of TakeWhile Method: ");
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();


            List<int> ResultMS1 = numbers.Where(x=>x<6).ToList();

            Console.Write("Result Of Where Method: ");
            foreach (var num in ResultMS1)
            {
                Console.Write($"{num} ");
            }


        }

        public void Test3()
        {

            List<string> names = new List<string>() { "Sara", "Rahul", "Joh", "Pam", "Priyanka" };


            List<string> namesResult = names.TakeWhile(names => names.Length > 3).ToList();
            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }

        }

        public void Test4()
        {
            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };

            List<string> namesResult = names.TakeWhile((name,index)=> name.Length> index).ToList();

            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }

        }
    }
}
