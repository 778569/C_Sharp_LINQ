using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LINQ_Except_Method
{
    public class Example02
    {

        public void Test()
        {

            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };

            var MS = dataSource1.Except(dataSource2,StringComparer.OrdinalIgnoreCase).ToList();

            var QS = (from data in dataSource2
                     select data).Except(dataSource1).ToList();


            foreach (var item in MS)
            {
                Console.WriteLine(item, " ");
            }

            Console.WriteLine();

            foreach (var item in QS)
            {
                Console.WriteLine(item, " ");
            }
        }
    }
}
