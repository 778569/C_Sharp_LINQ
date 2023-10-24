using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OrderBy_Method
{
    public class Example01
    {

        public void Test()
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };


            var MS = intList.OrderBy(x=>x).ToList();


            var QS = (from list in intList
                      orderby list
                      select list).ToList();

            foreach (var item in MS)
            {
                Console.Write(item + " ");
            }
        }



        public void Test02()
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan",
            "Hina","Kumar","Manoj", "Rout", "James"};


            var MS = stringList.OrderBy(x=>x).ToList();

            var QS = (from sList in stringList
                      orderby sList ascending
                      select sList).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
