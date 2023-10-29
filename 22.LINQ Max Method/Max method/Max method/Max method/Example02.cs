using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_method
{
    public class Example02
    {

        public void Test()
        {
            var HighstSalary = Employee.GetAllEmployees().Max(emp=>emp.Salary);

            var QSHighestSalary = (from emp in Employee.GetAllEmployees()
                     select emp).Max(emp=>emp.Salary);

            Console.WriteLine("Highest Salary = " + QSHighestSalary);
        }


        public void Test1()
        {
            int MS = Employee.GetAllEmployees().Where(emp => emp.Department == "IT").Max(emp=>emp.Salary);

            var QS = (from emp in Employee.GetAllEmployees()
                      where emp.Department == "IT"
                      select emp).Max(x => x.Salary);

            Console.WriteLine("Highest Salary = " + MS);
        }

        public void Test3()
        {
            int MS = Employee.GetAllEmployees().Max(emp =>
            {
                if (emp.Department == "IT")
                {
                    return emp.Salary;
                } else
                {
                    return 0;
                }
            });
            Console.WriteLine("It Department Highest Salary = " + MS);
        }
    }
}
