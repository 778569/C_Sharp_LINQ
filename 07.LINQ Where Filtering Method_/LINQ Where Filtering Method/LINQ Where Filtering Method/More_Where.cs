using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Where_Filtering_Method
{
    public class More_Where
    {

        public void Test()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int index = 0;

            //IEnumerable<int> OddNumbers =intList.Where(x => x % 2 != 0); // Get Odd numbers using where But I want get index number also, Here I can use for loop for get index number but I want to use LINQ for that.

            //var OddNumbers = intList.Select((num, index) => new  
            //                              { 
            //                                   Numbers = num,
            //                                   IndexPosition = index
            //                              })
            //                                .Where(x => x.Numbers % 2 != 0)
            //                                .Select(data => new 
            //                                {
            //                                   Number = data.Numbers,
            //                                   IndexPosition = data.IndexPosition
                                          
            //                                });

            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine($"IndexPosition : {item.IndexPosition} , Value : {item.Number}");
            //}






            var OddNumbers_Queery = from num in intList.Select((num, index) => 
                                    new
                                    {
                                        Numbers = num,
                                        IndexNum = index
                                    })
                                    where num.Numbers % 2 != 0
                                    select new
                                    {
                                        Number = num.Numbers,
                                        IndexNum = num.IndexNum
                                    };


            foreach (var item in OddNumbers_Queery)
            {
                Console.WriteLine($"IndexPosition : {item.IndexNum} , Value : {item.Number}");

            }
        }





    }
}
