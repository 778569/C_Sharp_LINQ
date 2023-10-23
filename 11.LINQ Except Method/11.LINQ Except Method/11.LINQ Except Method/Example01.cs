using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LINQ_Except_Method
{
    public class Example01
    {

        public void Test()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

            var MS2 = dataSource2.Except(dataSource1).ToList();

            foreach (var item in MS2)
            {
                Console.Write(item + " ");
            }

            //var MS = dataSource1.Except(dataSource2).ToList();


            //var QS = (from num in dataSource1 
            //         select num).Except(dataSource2).ToList();


            //foreach (var item in MS)
            //{
            //    Console.Write(item + " ");
            //}


            // Use the 1st data to Except



        }
    }
}
