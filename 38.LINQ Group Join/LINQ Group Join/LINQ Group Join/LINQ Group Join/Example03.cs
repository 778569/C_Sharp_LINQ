using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Group_Join
{
    public class Example03
    {
        public void Test()
        {
            var GroupJoinMS = Department.GetAllDepartments()
                .GroupJoin(
                Employee.GetAllEmployees(),
                dep => dep.ID,
                emp => emp.DepartmentId, 
                (dep, emp) => new GroupEmployeeByDepartment
                {
                    Department = dep,
                    Employees = emp.ToList(),
                }
            );



            var GroupJoinQS = from dep in Department.GetAllDepartments()
                              join emp in Employee.GetAllEmployees()
                              on dep.ID equals emp.DepartmentId
                              into EmployeeGroups
                              select new GroupEmployeeByDepartment
                              {
                                  Department = dep,
                                  Employees = EmployeeGroups.ToList(),
                              };

            foreach (var item in GroupJoinQS)
            {
                Console.WriteLine("Department :" + item.Department.Name);
                foreach (var employee in item.Employees)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
        }
    }
}
