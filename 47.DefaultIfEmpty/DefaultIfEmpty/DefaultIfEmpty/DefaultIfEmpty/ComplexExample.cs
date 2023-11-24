using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultIfEmpty
{
    public class ComplexExample
    {
        List<Employee> employees = Employee.GetAllEmployees();

        Employee emp5 = new Employee() { ID = 5, Name = "Hina", Salary = 10000, Gender = "Female" };

        public void Test()
        {
            var MS = employees.DefaultIfEmpty(emp5);

            var QS = (from emp in employees
                     select emp).DefaultIfEmpty(emp5);

            foreach (var emp in MS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Gender:{emp.Gender}, Salary:{emp.Salary} ");
            }
        }
    }
}
