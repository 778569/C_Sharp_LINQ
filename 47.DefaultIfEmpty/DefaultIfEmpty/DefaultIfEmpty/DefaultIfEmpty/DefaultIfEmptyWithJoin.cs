using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultIfEmpty
{
    public class DefaultIfEmptyWithJoin
    {
        public void Test()
        {
            //Using DefaultIfEmpty Method which does not take any parameter

            var query1 = from stu in Student.GetAllEmployees() //Left Data Source
                         join add in Address.GetAddress() //Right Data Source
                         on stu.AddressId equals add.ID //Inner Join Condition
                         into StudentAddressGroup //Performing LINQ Group Join
                         from address in StudentAddressGroup.DefaultIfEmpty() //Performing Left Outer Join

                         select new
                         {
                             EmployeeID = stu.ID,
                             Name = stu.Name,
                             Address = address.AddressLine ?? "NA" //Check for Null
                         };

            //Using Second Overloaded Version of DefaultIfEmpty Method which takes default value as a parameter
            var query2 = from employee in Student.GetAllEmployees() //Left Data Source
                         join address in Address.GetAddress() //Right Data Source
                         on employee.AddressId equals address.ID //Inner Join Condition
                         into EmployeeAddressGroup //Performing LINQ Group Join
                         from address in EmployeeAddressGroup.DefaultIfEmpty(new Address() { AddressLine = "Address Not Available" }) //Performing Left Outer Join
                         select new //Projecting the Result to Anonymous Type
                         {
                             EmployeeId = employee.ID,
                             Name = employee.Name,
                             Addrees = address.AddressLine
                         };
            foreach (var item in query1)
            {
                Console.WriteLine($"EmployeeId: {item.EmployeeID}, Name: {item.Name}, Address: {item.Address}");
            }
        }
    }

    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<Address> GetAddress()
        {
            return new List<Address>()
            {
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 6, AddressLine = "AddressLine6"},
            };
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<Student> GetAllEmployees()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety", AddressId = 1},
                new Student { ID = 2, Name = "Priyanka", AddressId =2},
                new Student { ID = 3, Name = "Anurag", AddressId = 0},
                new Student { ID = 4, Name = "Pranaya", AddressId = 0},
                new Student { ID = 5, Name = "Hina", AddressId = 5},
                new Student { ID = 6, Name = "Sambit", AddressId = 6}
            };
        }
    }
}
