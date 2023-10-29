using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Average_Method
{
    public class Example01
    {

        public void Test()
        {
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };

            var MS = intNumbers.Average(num =>
            {
                if (num > 50)
                {
                    return num;
                }
                else
                {
                    return 0;
                }
            });

            var QSAverageValue = (from num in intNumbers
                                  select num).Average(num => {
                                      if (num > 50)
                                          return num;
                                      else
                                          return 0;
                                  });


            Console.WriteLine("Average : " + MS);




            //var MS = intNumbers.Where(num=>num > 50).Average();

            //var QS = (from num in intNumbers
            //         where num > 50
            //         select num).Average();

            //Console.WriteLine("Average : " + MS);

            //var MS = intNumbers.Average();

            //var QS = (from num in intNumbers
            //         select num).Average();

            //Console.WriteLine("Average : " + MS);
        }
    }
}
