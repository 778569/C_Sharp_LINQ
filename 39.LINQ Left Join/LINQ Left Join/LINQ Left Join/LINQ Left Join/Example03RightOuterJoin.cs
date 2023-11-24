using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Left_Join
{
    public class Example03RightOuterJoin
    {

        public void Test()
        {
            var RightJoinQS = from add in Address.GetAddress()
                              join emp in Employee.GetAllEmployees()
                              on add.ID equals emp.AddressId
                              into EmployeeGroup
                              from emp in EmployeeGroup.DefaultIfEmpty()
                              select new
                              {
                                  Employee = emp,
                                  Address = add
                              };
            foreach (var item in RightJoinQS)
            {
                Console.WriteLine($"Name : {item.Employee?.Name}, Address : {item.Address?.AddressLine} ");
            }
        }
    }
}
