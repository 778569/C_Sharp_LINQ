using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Multiple_Data_Sources
{
    public class Example01
    {
        public void Test()
        {
            var JoinMultipleDSUsingQS = (from emp in Employee.GetAllEmployees()
                                        join adrs in Address.GetAllAddresses()
                                        on emp.AddressId equals adrs.ID
                                        join dept in Department.GetAllDepartments()
                                        on emp.DepartmentId equals dept.ID
                                        select new
                                        {
                                            ID = emp.ID,
                                            EmployeeName= emp.Name,
                                            DepartmentName= dept.Name,
                                            AddressLine = adrs.AddressLine,
                                        }).ToList();

            foreach (var employee in JoinMultipleDSUsingQS)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.EmployeeName}, Department = {employee.DepartmentName}, Addres = {employee.AddressLine}");
            }
        }
    }
}
