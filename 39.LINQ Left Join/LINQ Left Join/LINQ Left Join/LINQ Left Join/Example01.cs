using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Left_Join
{
    public class Example01
    {
        public void Test()
        {
            //Performing Left Outer Join using LINQ using Query Syntax
            //Left Data Source: Employees
            //Right Data Source: Addresses
            //Note: Left and Right Data Source Matters
            var QSOuterJoin = from emp in Employee.GetAllEmployees() //Left Data Source
                              join add in Address.GetAddress() //Right Data Source
                              on emp.AddressId equals add.ID //Inner Join Condition
                              into EmployeeAddressGroup //Performing LINQ Group Join
                              from address in EmployeeAddressGroup.DefaultIfEmpty() //Performing Left Outer Join
                              select new 
                              {
                                emp,address
                              }; //Projecting the Result to Anonymous Type


            foreach (var item in QSOuterJoin)
            {
                //Before Accessing the AddressLine, please check null else you will get Null Reference Exception
                Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            }
        }
    }
}
