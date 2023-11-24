using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skip_Method
{
    public class ComplexType
    {
        public void Test()
        {
            List<Employee> employee = Employee.GetAllEmployees();

            List<Employee> employeeMS = employee.OrderBy(emp=>emp.Salary).Skip(4).ToList();

            List<Employee> employeeQS = (from emp in employee
                                         orderby emp.Salary
                                         select emp).Skip(4).ToList();

            foreach (var emp in employeeMS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Gender:{emp.Gender}, Salary:{emp.Salary}");
            }
        }
    }
}
