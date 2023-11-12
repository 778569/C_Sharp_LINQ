using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_All_Method
{
    public class Example01
    {
        public void Test()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };

            bool ResultMS = IntArray.All(x=>x > 10);
            //Check All the element greater than 10

            bool ResultQS = (from num in IntArray
                             select num).All(x=>x < 10);

            Console.WriteLine("Is All Numbers are greater than 10 : " + ResultMS);
            Console.WriteLine("Is All Numbers are less  than 10 : " + ResultQS);

        }


        public void Test1()
        {
            string[] StringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };

            var StringMS = StringArray.All(x=>x.Length > 10);

            var StringQS = (from num in StringArray
                            select num).All(x=>x.Length<10);

            Console.WriteLine("Is All String length of characters are greater than 10 : " + StringMS);
            Console.WriteLine("Is All String length of characters are less than 10 : " + StringQS);


        }

        
    }
}
