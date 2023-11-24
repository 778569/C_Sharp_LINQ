using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_FirstOrDefault
{
    public class FirstExample01
    {
        public void Test()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Fetching the First Element from the Data Source which is Divisble by 2

            var MethodSyntax = numbers.First(x => x % 2 == 0);


            var QuerySyntax = (from num in numbers
                               select num).First(num => num % 2 == 0);

            Console.WriteLine(MethodSyntax);


            //int MethodSyntax = numbers.First();

            //int QuerySyntax = (from num in numbers
            //                  select num).First();

        }

        public void Test1()
        {
            List<int> numbersEmpty = new List<int>() { };

            //int MethodSyntax = numbersEmpty.First();

            //Console.WriteLine(MethodSyntax);

        }

        public void Test2() 
        {

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int MethodSyntax = numbers.First(x => x > 50);

            //Console.WriteLine(MethodSyntax);

        }
    }
}
