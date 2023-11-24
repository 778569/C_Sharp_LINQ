using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEqual_Method
{
    public class Example01
    {
        public void Test()
        {
            List<string> cityList1 = new List<string>()
            {
                "Delhi", "Mumbai", "Hyderabad"
            };

            List<string> cityList2 = new List<string> ()
            { 
                "Delhi", "Mumbai", "Hyderabad" 
            };

            List<string> cityList3 = new List<string>() 
            { 
                "delhi", "MUMBAI", "Hyderabad" 
            };


            bool IsEqualMS = cityList2.SequenceEqual(cityList3, StringComparer.OrdinalIgnoreCase);

            bool IsEqualQS = (from city in cityList2
                              select city).SequenceEqual(cityList3, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(IsEqualMS);

            //bool IsEqualMS = cityList1.SequenceEqual(cityList2);

            //bool ISEqualSQ = (from city in cityList1
            //                  select city).SequenceEqual(cityList2);

            //Console.WriteLine(IsEqualMS);
        }

        public void Test2()
        {
            // Not in same order

            List<string> cityList1 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            //Collection 1 or Sequenece 1
            List<string> cityList2 = new List<string> { "Delhi", "Hyderabad", "Mumbai" };

            var IsEqualMS = cityList1.OrderBy(city => city).SequenceEqual(cityList2.OrderBy(city=>city), StringComparer.OrdinalIgnoreCase);

            bool IsEqualQS = (from city in cityList1
                              orderby city ascending
                              select city).SequenceEqual(cityList2.OrderBy(city => city), StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(IsEqualMS);

            //bool IsEqualMS = cityList1.SequenceEqual(cityList2, StringComparer.OrdinalIgnoreCase);

            //bool IsEqualQS = (from city in cityList1
            //                  select city).SequenceEqual(cityList2, StringComparer.OrdinalIgnoreCase);

        }

    }
}
