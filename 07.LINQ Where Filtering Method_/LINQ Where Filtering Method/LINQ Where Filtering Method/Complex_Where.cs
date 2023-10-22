using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Where_Filtering_Method
{
    public class Complex_Where
    {

        public void Test()
        {
            var QuerySyntax = from emp in Employee.GetEmployees() where emp.Salary > 5000 select emp;


            var MethodSyntax = Employee.GetEmployees().Where(emp => emp.Salary > 5000).ToList();


            foreach (var item in QuerySyntax)
            {

                Console.WriteLine("Id = {0} , Name = {1} , Gender = {2} , Salary= {3}", item.ID,item.Name,item.Gender);

                if (item.Technology != null && item.Technology.Count>0) 
                {
                    Console.Write(" Technology : ");
                    foreach (var tech in item.Technology)
                    {
                        Console.Write(tech + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Technology Not Available ");
                }

            }
        }


        public void Test2()
        {



            var QuerySyntax = (from emp in Employee.GetEmployees()
                               where emp.Salary >= 50000 && emp.Technology != null
                               select new
                               {
                                   Name = emp.Name,
                                   Gender = emp.Gender,
                                   Salary = emp.Salary / 12

                               }).ToList();

            var MethodSyntax = Employee.GetEmployees().Where(x => x.Salary > 5000 && x.Technology != null).Select(emp => new
            {

                Name = emp.Name,
                Gender = emp.Gender,
                Salary = emp.Salary/12

            }).ToList();

            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"Name : {emp.Name}, Gender : {emp.Gender}, Monthly Salary : {emp.Salary}");
            }

        }



        public void Test_Using_Index()
        {

            var QuerySyntax = (from data in Employee.GetEmployees().Select((Data, index) => new
            {
                employee = Data,
                Index = index
            })
                               where data.employee.Salary >= 50000 && data.employee.Gender == "Male"
                               select new
                               {
                                   EmployeeName = data.employee.Name,
                                   Gender = data.employee.Gender,
                                   Salary = data.employee.Salary,
                                   IndexPosition = data.Index
                               }).ToList();


            //Method Syantax

            var MethodSyantax = Employee.GetEmployees().Select((Data, index) => new
            {
                employee = Data,
                Index = index

            }).Where(emp => emp.employee.Salary >= 50000 && emp.employee.Gender == "Male").Select(emp => new
            {

                EmployeeName = emp.employee.Name,
                Gender = emp.employee.Gender,
                Salary = emp.employee.Salary,
                IndexPosition = emp.Index
            }).ToList();
            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"Position : {emp.IndexPosition} Name : {emp.EmployeeName}, Gender : {emp.Gender}, Salary : {emp.Salary}");
            }

        }
    }
}
