using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Any_Method
{
    public class Example01
    {
        public void test()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };

            var MS = IntArray.Any();

            var QS = (from num in IntArray
                      select num).Any();

            Console.WriteLine("Is there any element in the collection: " + MS);
        }

        public void Test1()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };

            var ResultMS = IntArray.Any(x => x > 10);

            var ResultQS = (from num in IntArray
                           select num).Any(x => x < 10);


            Console.WriteLine("Is There Any Element grater than 10: " + ResultMS);

            Console.WriteLine("Is There Any Element Less than 10: " + ResultQS);
        }

        public void StringTest()
        {
            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };

            var StringMS = stringArray.Any(x => x.Length > 10);

            var StringQS = (from Str in stringArray
                            select Str).Any(x => x.Length < 10);

            Console.WriteLine("Is Any name with a Length greater than 10 Characters: " + StringMS);
            Console.WriteLine("Is Any name with a Length less than 10 Characters: " + StringQS);

        }
    }
}
