using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Min_Method
{
    public class Example01
    {

        public void Test()
        {
            int LowSalaryMS = Employee.GetAllEmployees().Min(emp => emp.Salary);

            int LowSalaryQS = (from emp in Employee.GetAllEmployees()
                              select emp).Min(emp => emp.Salary);   

            Console.WriteLine("Lowest Salary : " + LowSalaryQS);
        }
    }
}
