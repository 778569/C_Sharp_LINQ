using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_method
{
    public class Example01
    {
        public void Test01()
        {
            int[] intNumbers = new int[] { 10, 80, 50, 90, 60, 30, 70, 40, 20, 100 };


            int MSLergestNumber = intNumbers.Max(num =>
            {
                if (num < 50)
                {
                    return num;
                }
                else
                {
                    return 0;
                }
            });

            Console.WriteLine("Largest Number = " + MSLergestNumber);







            // Less than 50 and mAx value

            //int MaxLess50 = intNumbers.Where(x => x < 50).Max();

            //int MaxLess50QS = (from num in intNumbers
            //                   where num < 50
            //                   select num).Max();

            //Console.WriteLine("Max Value : " + MaxLess50);





            //int MaxMS = intNumbers.Max();

            //int MaxQS = (from num in intNumbers
            //            select num).Max();

            //Console.WriteLine("Max Value : " + MaxMS);






        }
    }
}
