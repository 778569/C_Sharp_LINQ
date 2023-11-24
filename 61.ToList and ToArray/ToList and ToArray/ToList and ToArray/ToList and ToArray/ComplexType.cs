using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToList_and_ToArray
{
    public class ComplexType
    {
        public void Test()
        {
            Employee[] EmployeesArray = new Employee[]
            {
                new Employee(){ID = 1, Name = "Kavinda", Department = "IT"},
                new Employee() { ID = 2, Name = "Buddhika", Department = "HR" },
                new Employee() { ID = 3, Name = "Bandara", Department = "HR" },
                new Employee() { ID = 4, Name = "Shakuni", Department = "IT" },
                new Employee() { ID = 5, Name = "Shantha", Department = "IT" }
            };

            List<Employee> EmployeesList = EmployeesArray.ToList();

            foreach (var emp in EmployeesArray)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}");
            }
        }
    }
}
