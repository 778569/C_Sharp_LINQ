using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Where_Filtering_Method
{
    public class Where_Test
    {
        public void Test()
        {

            List<int> intList = new List<int>()
            {
            1,2, 3, 4,5,6,7,8,9,10
            };

            IEnumerable<int> filteredData = intList.Where(x => x > 5);

            IEnumerable<int> filteredResult = from x in intList
                                              where x > 5
                                              select x;

            foreach (var number in filteredData)
            {
                Console.WriteLine(number);
            }
        }


        public void Test2()
        {

            List<int> intList = new List<int>()
            {
            1,2, 3, 4,5,6,7,8,9,10
            };

            IEnumerable<int> filteredData = intList.Where(num=> CheckNumber(num));

            foreach (var number in filteredData)
            {
                Console.WriteLine(number);
            }
        }

        public static bool CheckNumber(int number)
        {

            if (number > 5 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
