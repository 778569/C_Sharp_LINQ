using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Method
{
    public class Example01
    {
        public void Test()
        {
            //Generating Intger Numbers from 1 to 10

            IEnumerable<int> numberSequence = Enumerable.Range(1,10);

            foreach (int num in numberSequence)
            {
                Console.Write($"{num} ");
            }
        }

        public void Test2() 
        {

            IEnumerable<int> EvenNumbers = Enumerable.Range(10, 40).Where(x => x % 2 == 0);

            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }


        }

        public void Test3()
        {
            IEnumerable<int> EvenNumbers = Enumerable.Range(1,5).Select(x => x*x);

            Console.WriteLine(string.Join(", ", EvenNumbers));
        }

        public void Test4()
        {
            IEnumerable<string> rangewithString = Enumerable.Range(1, 5).Select(x => (x * x) + " " + CustomLogic(x)).ToArray();
            foreach (var item in rangewithString)
            {
                Console.WriteLine(item);
            }

        }

        private static string CustomLogic(int x)
        {
            string result = string.Empty;
            switch (x)
            {
                case 1:
                    result = "1st";
                    break;
                case 2:
                    result = "2nd";
                    break;
                case 3:
                    result = "3rd";
                    break;
                case 4:
                    result = "4th";
                    break;
                case 5:
                    result = "5th";
                    break;
            }
            return result;
        }

        public void RangeWithDate()
        {
            DateTime startDate = new DateTime(2023, 11, 23);

            int daysToGenerate = 10;

            var dateSequence = Enumerable.Range(0, daysToGenerate).Select(offset => startDate.AddDays(offset));

            foreach (var date in dateSequence)
            {
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
}
