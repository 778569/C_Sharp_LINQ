using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Inner_Join
{
    public class Example03
    {

        public void Test()
        {
            var JoinUsingQS =  (from employee in Employee.GetAllEmployees()
                               join address in Address.GetAllAddresses()
                               on employee.AddressId equals address.ID

                               select new EmployeeAddress
                               {
                                   EmployeeName = employee.Name,
                                   AddressLine = address.AddressLine
                               }).ToList();

            foreach (var employee in JoinUsingQS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
        }
    }
}
