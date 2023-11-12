using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Inner_Join
{
    public class Example02
    {
        public void Test()
        {

            var JoinMS = Employee.GetAllEmployees().Join(Address.GetAllAddresses(), employee => employee.AddressId, address => address.ID, (employee,address) => new EmployeeAddress
            {
                EmployeeName = employee.Name,
                AddressLine = address.AddressLine
            }).ToList();

            foreach (var employee in JoinMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }

        }
    }
}
