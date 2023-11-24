using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Group_Join
{
    public class Example01
    {
        public void Test()
        {
            //Group Employees by Department using Method Syntax
            var GroupJoinMS = Department.GetAllDepartments() //Outer Data Source i.e. Departments
                .GroupJoin(Employee.GetAllEmployees(),
                dep => dep.ID, //Outer Key Selector  i.e. the Common Property
                emp => emp.DepartmentId, //Inner Key Selector  i.e. the Common 
                (dep, emp) => new
            {
                Depertment = dep,
                Employee = emp
            }); //Projecting the Result to an Anonymous Type

            foreach (var item in GroupJoinMS)
            {
                Console.WriteLine("Department :" + item.Depertment.Name);
                foreach (var employee in item.Employee)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
        }
    }
}
