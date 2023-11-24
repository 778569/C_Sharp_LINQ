using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Left_Join
{
    public class Example02
    {
        public void test()
        {


            var MSOuterJOIN = Employee.GetAllEmployees().GroupJoin(Address.GetAddress(), emp => emp.AddressId, add => add.ID, (emp, add) => new { emp, add }
            ).SelectMany(x => x.add.DefaultIfEmpty(), (employee, address) => new EmployeeResult
            {
                Employee = employee.emp,
                Address = address
            });
            foreach (var item in MSOuterJOIN)
            {
                Console.WriteLine($"Name : {item.Employee.Name}, Address : {item.Address?.AddressLine} ");
            }
        }
    }
}
