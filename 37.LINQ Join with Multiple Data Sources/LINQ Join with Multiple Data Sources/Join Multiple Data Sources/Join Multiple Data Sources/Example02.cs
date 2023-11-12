using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Multiple_Data_Sources
{
    public class Example02
    {
        public void Test()
        {
            var JoinMultipleMS = Employee.GetAllEmployees().Join(Address.GetAllAddresses(),
                employee => employee.AddressId,
                addLevel => addLevel.ID,
                (employee, addLevel) => new
                {
                    employee,
                    addLevel
                }
                ).Join(Department.GetAllDepartments(),
                employeeLevel => employeeLevel.employee.DepartmentId, dep => dep.ID, (employeeLevel, dep) => new EmployeeResult
                {

                    ID = employeeLevel.employee.ID,
                    EmployeeName = employeeLevel.employee.Name,
                    AddressLine = employeeLevel.addLevel.AddressLine,
                    DepartmentName = dep.Name
                }).ToList();

            foreach (var employee in JoinMultipleMS)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.EmployeeName}, Department = {employee.DepartmentName}, Addres = {employee.AddressLine}");
            }
        }
    }
}
