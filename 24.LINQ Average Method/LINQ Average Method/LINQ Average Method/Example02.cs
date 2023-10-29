using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Average_Method
{
    public class Example02
    {

        public void Test()
        {

            var MS = Employee.GetAllEmployees().Average(emp => emp.Salary);

            var QS = (from emp in Employee.GetAllEmployees() select emp).Average(emp => emp.Salary);

            Console.WriteLine("Average Salary = " + MS);

        }

        public void Test1()
        {
            var MS = Employee.GetAllEmployees().Where(x=>x.Department == "IT").Average(emp => emp.Salary);

            var QS = (from emp in Employee.GetAllEmployees()
                      where emp.Department == "IT"
                      select emp).Average(x => x.Salary);

            Console.WriteLine("Average Salary = " + MS);
        }
    }
}
