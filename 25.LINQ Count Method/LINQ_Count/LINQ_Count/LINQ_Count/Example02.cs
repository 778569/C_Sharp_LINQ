using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Count
{
    public class Example02
    {
        public void Test()
        {
            var MS = Employee.GetAllEmployees().Count();

            var QS = (from emp in Employee.GetAllEmployees()
                     select emp).Count();   

            Console.WriteLine("Count : " + MS);
        }
    }
}
