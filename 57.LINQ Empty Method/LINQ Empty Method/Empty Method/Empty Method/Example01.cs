using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty_Method
{
    public class Example01
    {
        public void Test()
        {
            IEnumerable<string> emptyCollection1 = Enumerable.Empty<string>();

            IEnumerable<Student> emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0}", emptyCollection1.Count());
            Console.WriteLine("Type : {0}",emptyCollection1.GetType().Name);

            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);
        }

        public void Test2()
        {
            IEnumerable<int> integerSequence = GetData();

            foreach (var num in integerSequence)
            {
                Console.WriteLine(num);
            }
        }

        private static IEnumerable<int> GetData()
        {
            return null;
        }

        public void Test3()
        {
            IEnumerable<int> integerSequence = GetData();

            if (integerSequence != null)
            {
                foreach (var num in integerSequence)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public void Test4()
        {
            IEnumerable<int> integerSequence = GetData() ?? Enumerable.Empty<int>();

            foreach (var num in integerSequence)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(integerSequence.Count());
        }
    }
}   
