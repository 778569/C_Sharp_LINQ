using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Group_Join
{
    public class Example02
    {
        public void Test()
        {
            var GroupJoinQS = from dep in Department.GetAllDepartments()
                              join emp in Employee.GetAllEmployees()

                              on dep.ID equals emp.DepartmentId
                              into EmployeeGroups
                              select new
                              {
                                  Department = dep,
                                  EmployeeGroups = EmployeeGroups
                              };

            foreach (var item in GroupJoinQS)
            {
                Console.WriteLine("Department :" + item.Department.Name);

                foreach (var employee in item.EmployeeGroups)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
        }
    }
}
