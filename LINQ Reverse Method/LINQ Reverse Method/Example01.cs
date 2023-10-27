using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ_Reverse_Method
{
    public class Example01
    {

        public void Test()
        {
            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };

            var MS = intArray.Reverse();



            var QS = (from list in intArray
                      select list).Reverse();


            foreach (var number in MS)
            {
                Console.Write(number + " ");
            }
        }



        public void Test2()
        {

            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan" };


            IEnumerable<string> ReverseData = stringList.AsEnumerable().Reverse();

            foreach (var name in ReverseData)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();

            IQueryable<string> ReverseData2 = stringList.AsQueryable().Reverse();

            foreach (var name in ReverseData2)
            {
                Console.Write(name + " ");
            }











            // var MS = stringList.Reverse();

            //You cannot store the data like below as this method belongs to
            //System.Collections.Generic namespace whose return type is void
            //IEnumerable<int> ArrayReversedData = stringList.Reverse();


            //stringList.Reverse();

            //foreach (var name in stringList)
            //{
            //    Console.Write(name + " ");
            //}
        }
    }
}
