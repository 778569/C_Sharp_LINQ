using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Sum_Method
{
    public class Example02
    {
        public void Test()
        {
            var MS = Employee.GetAllEmployees().Select(x => x.Salary).Sum();

            //var MS = Employee.GetAllEmployees().Sum(x=>x.Salary);

            var QS = (from emp in Employee.GetAllEmployees()
                      select emp).Sum(x => x.Salary);


           Console.WriteLine("Sum Of Salary = " + MS);
        }

        public void Test2() 
        {

            var MS = Employee.GetAllEmployees().Where(x => x.Department == "IT").Sum(x => x.Salary);

            Console.WriteLine("Sum of Salary : " + MS);


            var QS = (from emp in Employee.GetAllEmployees()
                      where emp.Department == "IT"
                      select emp).Sum(x => x.Salary);
        
        }
    }
}
