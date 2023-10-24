using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Union_Method
{
    public class Example01
    {
        public void Test()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

            var MS = dataSource1.Union(dataSource2).ToList();

            var QS = (from ds in dataSource1
                     select ds).Union(dataSource2).ToList();


            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in MS)
            {
                Console.Write(item + " ");
            }
        }
    }
}
