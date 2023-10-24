using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Concat_Method
{
    public class Example01
    {

        public void Test()
        {

            List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
            List<int> sequence2 = new List<int> { 2, 4, 6, 8 };

            var MS = sequence1.Concat(sequence2).ToList();

            var QS = (from qs in sequence1
                     select qs).Concat(sequence2).ToList();


            foreach (var item in MS)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }
        }
    }
}
