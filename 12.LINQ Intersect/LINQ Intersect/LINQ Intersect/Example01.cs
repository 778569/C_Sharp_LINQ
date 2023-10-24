using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Intersect
{
    public class Example01
    {
        List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };


        public void Test01()
        {


            var MS = dataSource1.Intersect(dataSource2).ToList();

            var QS = (from test in dataSource2
                     select test).Intersect(dataSource1).ToList();


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
