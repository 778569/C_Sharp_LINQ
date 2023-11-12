using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Contains_Method
{
    public class Example01
    {

        public void Test()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };

            var IsExistsMS = IntArray.Contains(33);

            var IsExistsQS = (from Num in IntArray
                              select Num).Contains(25);

             Console.WriteLine($"Is Element 33 Exist: {IsExistsMS}");

            Console.WriteLine($"Is Element 25 Exist: {IsExistsQS}");
        }

        public void Test1()
        {
            List<string> namesList = new List<string>() { "James", "Sachin", "Sourav", "Pam", "Sara" };

            var IsExistsMS1 = namesList.Contains("Sachin");

            //This method belongs to System.Linq namespace
            var IsExistsMS2 = namesList.AsEnumerable().Contains("Sourav");


            var IsExistsQS = (from num in namesList
                              select num).Contains("Kavinda");


            Console.WriteLine($"Is Name Anurag Exist: {IsExistsMS1}");

            Console.WriteLine($"Is Name Anurag Exist: {IsExistsQS}");
        }
    }
}
