using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Method
{
    public class ComplexTypeExample
    {
        public void Test()
        {
            List<Employee> employees = Employee.GetAllEmployees();

            List<Employee> employeesMS = employees.OrderByDescending(emp=>emp.Salary).Take(4).ToList();

            List<Employee> employeesQS = (from emp in employees
                                          orderby emp.Salary descending
                                          select emp).Take(4).ToList();

            foreach (Employee emp in employeesMS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Gender:{emp.Gender}, Salary:{emp.Salary}");
            }
        }
    }
}
