using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Cast_and_OfType
{
    public class Cast
    {
        ArrayList list = new ArrayList
            {
                10,
                20,
                30,
                "50"
            };

        public void Test2()
        {
            IEnumerable<int> result = list.OfType<int>();

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        public void Test()
        {

            IEnumerable<int> result = list.Cast<int>();

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }
        
    }
}
