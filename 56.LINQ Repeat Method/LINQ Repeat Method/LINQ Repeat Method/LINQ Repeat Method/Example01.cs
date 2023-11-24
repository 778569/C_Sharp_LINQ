using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Repeat_Method
{
    public class Example01
    {
        public void Test()
        {
            IEnumerable<string> repeatStrings = Enumerable.Repeat("Welcome to DOT NET Tutorials", 10);

            foreach (string str in repeatStrings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
