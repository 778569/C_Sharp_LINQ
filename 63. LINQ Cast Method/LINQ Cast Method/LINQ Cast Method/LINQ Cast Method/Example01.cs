using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Cast_Method
{
    public class Example01
    {
        public void Test()
        {
            ArrayList list = new ArrayList()
            {
                10, 20 , 30
            };

            IEnumerable<int> result = list.Cast<int>();

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public void Test2() 
        {

            ArrayList list = new ArrayList()
            {
                10, 20 , 30
            };

            list.Add(40);

            var result = list.Cast<int>();

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}
