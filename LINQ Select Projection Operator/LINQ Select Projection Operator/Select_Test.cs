using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Select_Projection_Operator
{
    public class Select_Test
    {

        public void Test()
        {
            //Querry

            //IEnumerable<Employee> querryEmp = (from emp in Employee.GetEmployees()
            //                                   select emp).ToList();

            //foreach (var item in querryEmp)
            //{
            //    Console.WriteLine("ID = {0}, First Name = {1}, Last name = {2} , Salary = {3}", item.ID,item.FirstName,item.LastName,item.Salary);
            //}

            //Console.WriteLine();
            ////LINQ


            //var LINQEmp = Employee.GetEmployees().Select(emp => emp).ToList();
            //// Or we shouldnt use select Keyword
            ////var LINQEmp = Employee.GetEmployees().ToList();

            //foreach (var item in LINQEmp)
            //{
            //    Console.WriteLine("ID = {0}, First Name = {1}, Last name = {2} , Salary = {3}", item.ID, item.FirstName, item.LastName, item.Salary);
            //}



            // Select Emloyee By ID (Just I want to get Id)

            //List<int> IDQEmp = (from emp in Employee.GetEmployees()
            //                                select emp.ID).ToList();
            //foreach (var item in IDQEmp)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();


            //IEnumerable<int> IDLINQEmp = Employee.GetEmployees().Select(emp => emp.ID).ToList();

            //foreach (var item in IDLINQEmp)
            //{
            //    Console.WriteLine(item);
            //}


            // Select Few Properies

            // Query
            //IEnumerable<Employee> SelectQ = (from emp in Employee.GetEmployees()
            //                         select new Employee()
            //                         {
            //                             FirstName = emp.FirstName,
            //                             LastName = emp.LastName,
            //                             Salary = emp.Salary,
            //                         });

            //foreach (var emp in SelectQ)
            //{
            //    Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            //}

            //Console.WriteLine();

            //List<Employee> LINQSelect = Employee.GetEmployees().Select(emp => new Employee()
            //{
            //    FirstName = emp.FirstName,
            //    LastName= emp.LastName, 
            //    Salary = emp.Salary,   
            //}).ToList();


            //foreach (var emp in LINQSelect)
            //{
            //    Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            //}

            //Console.ReadKey();



            // Doing calculation and using Anonymous type


            //var Quey = (from emp in Employee.GetEmployees()
            //            select new
            //            {
            //                EmployeeId = emp.ID,
            //                FullName = emp.FirstName + " "+  emp.LastName,
            //                AnnualSalary =  emp.Salary * 12

            //            });

            //foreach (var emp in Quey)
            //{
            //    Console.WriteLine($" ID {emp.EmployeeId} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
            //}
            //Console.WriteLine();

            //var Linkx = Employee.GetEmployees().Select(emp => new
            //{
            //   EmployeeID = emp.ID,
            //   FullName = emp.FirstName + " " + emp.LastName,
            //   AnnualSalary = emp.Salary * 12
            //}).ToList();

            //foreach (var emp in Linkx)
            //{
            //    Console.WriteLine($" ID {emp.EmployeeID} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
            //}


            // Get Vale From index.

            //Query 
            var query = (from emp in Employee.GetEmployees().Select((value , index) => new { value , index})
                        select new
                        {
                            IndexPosition = emp.index,
                            FullName = emp.value.FirstName + emp.value.LastName,
                            Salary = emp.value.Salary,
                        }).ToList();

            foreach (var emp in query)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }

            //Method syntax
            Console.WriteLine();

            var selectedMethod = Employee.GetEmployees().Select((emp, index) => new
            {
                IndexPosition = index,
                FullName = emp.FirstName +" "+ emp.LastName,
                Salary = emp.Salary
            });

            foreach (var emp in selectedMethod)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }

        }

    }
}
