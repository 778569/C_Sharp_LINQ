using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToList_and_ToArray
{
    public class Example01
    {
        public void Test()
        {
            int[] numbersArray = { 10, 22, 30, 40, 50, 60 };

            List<int> numbersList = numbersArray.ToList();

            foreach (var num in numbersList)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
