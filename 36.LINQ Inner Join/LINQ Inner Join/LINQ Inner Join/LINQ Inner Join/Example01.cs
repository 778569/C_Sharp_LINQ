using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Inner_Join
{
    public class Example01
    {
        public void Test()
        {
            //Performing Inner Between Employees and Addresses Data Sources
            var JoinUsingMS = Employee.GetAllEmployees() //Inner Data Source
                .Join(Address.GetAllAddresses(),//Outer Data Source
                employee =>employee.AddressId,  //Outer Key Selector
                address =>address.ID,//Inner Key selector
                (employee, address) => new //Projecting the data into an Annonymous Type
                {
                    EmployeeName = employee.Name,
                    AddressLine = address.AddressLine,
                }).ToList();


            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
        }
    }
}
