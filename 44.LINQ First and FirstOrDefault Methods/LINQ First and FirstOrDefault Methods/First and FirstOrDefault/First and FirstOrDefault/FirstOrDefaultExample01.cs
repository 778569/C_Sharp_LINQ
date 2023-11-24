using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_FirstOrDefault
{
    public class FirstOrDefaultExample01
    {
        public void Test()
        {
            //Empty Data Source
            List<int> numbersEmpty = new List<int>();

            var MS1 = numbersEmpty.FirstOrDefault();

            var QS1 = (from num in numbersEmpty
                       select num).FirstOrDefault();

            //Console.WriteLine(MS1);

            //Specified condition doesnot return any element
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int MS = numbers.FirstOrDefault(x => x > 50);
            int QS = (from num in numbers
                      select num).FirstOrDefault(x=>x > 50);

            Console.WriteLine(MS);


        }
    }
}
