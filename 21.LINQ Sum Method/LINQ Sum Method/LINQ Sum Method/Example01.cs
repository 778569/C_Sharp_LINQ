using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Sum_Method
{
    public class Example01
    {

        public void Test()
        {
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };


            //Where Extension

            int MSTotal1 = intNumbers.Where(x => x > 50).Sum();

            Console.WriteLine("Total : " + MSTotal1);

            int MSTotal2 = (from num in intNumbers
                           where num >50
                           select num).Sum();





            //int MSTotal = intNumbers.Sum();

                               //int QSTotal= (from num in intNumbers
                               //             select num).Sum();

                               //Console.WriteLine("Total : " + MSTotal);
        }




        public void Test1()
        {

            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };


            var MS = intNumbers.Sum(x =>
            {
                if (x > 50)
                {
                    return x;
                }
                else
                {
                    return 0;
                }
            });

            int QS = (from num in intNumbers
                      select num).Sum(x =>
                      {
                          if (x > 50)
                          {
                              return x;
                          }
                          else return 0;
                      });

            Console.WriteLine("Sum = " + MS);

        }






    }
}
