using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Method
{
    public class Example01
    {

        public void Test()
        {
            List<int> intSequence = new List<int> { 10, 20, 30, 40 };

            // Trying to append 5 at the end of the intSequence
            intSequence.Append(5);

            //It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", intSequence));

            Console.WriteLine();
            // It works now because we are using a changed copy of the original sequence
            Console.WriteLine(string.Join(", ",intSequence.Append(5)));

            // Creating a new sequence explicitly
            List<int> newintSeq = intSequence.Append(5).ToList();

            Console.WriteLine(string.Join(", ", newintSeq));

        }

        public void Test2() 
        {

            var numbers = new[] { 1, 2, 3 };
            var result = numbers.Where(x => x % 2 == 1) //ODd numbers 
                                .Select(x => x * 10).Append(100); // Multiply them by 10 and Append the number 100 to the end

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }

    }
}
