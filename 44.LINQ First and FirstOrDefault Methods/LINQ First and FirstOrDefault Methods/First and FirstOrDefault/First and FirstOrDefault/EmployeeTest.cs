using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_FirstOrDefault
{
    public class EmployeeTest
    {
        public void Test()
        {
            List<Employee> listEmployee = Employee.GetAllEmployees();

            Employee Employee1 = listEmployee.First();
            Console.WriteLine($"{Employee1.ID}, {Employee1.Name}, {Employee1.Gender}, {Employee1.Salary}");

            Employee Employee2 = listEmployee.First(emp => emp.Gender == "Male");
            Console.WriteLine($"{Employee2.ID}, {Employee2.Name}, {Employee2.Gender}, {Employee2.Salary}");

            Employee Employee3 = listEmployee.First(emp => emp.Salary < 30000);
            Console.WriteLine($"{Employee3.ID}, {Employee3.Name}, {Employee3.Gender}, {Employee3.Salary}");
        }

        public void Test1()
        {
            //Data Source
            List<Employee> listEmployees = Employee.GetAllEmployees();

            //Fetching the First Employee from listEmployees Collection
            Employee Employee1 = listEmployees.FirstOrDefault();
            Console.WriteLine($"{Employee1.ID}, {Employee1.Name}, {Employee1.Gender}, {Employee1.Salary}");

            //Fetch the First Employee where the Gender is Female
            Employee Employee2 = listEmployees.FirstOrDefault(emp => emp.Gender == "Female");
            Console.WriteLine($"{Employee2.ID}, {Employee2.Name}, {Employee2.Gender}, {Employee2.Salary}");

            //Fetch the First Employee where the Salary is greater than 30000
            Employee Employee3 = listEmployees.First(emp => emp.Salary > 30000);
            Console.WriteLine($"{Employee3.ID}, {Employee3.Name}, {Employee3.Gender}, {Employee3.Salary}");
        }
    }
}
