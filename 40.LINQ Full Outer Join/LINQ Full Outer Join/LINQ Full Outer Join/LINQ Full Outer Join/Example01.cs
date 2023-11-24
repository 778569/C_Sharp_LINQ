using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Full_Outer_Join
{
    public class Example01
    {

        public void Test()
        {
            var LeftOuterJoin = from emp in Employee.GetAllEmployees()
                                join dep in Department.GetAllDepartments()
                                on emp.DepartmentId equals dep.ID
                                into EmployeeDepartmentGroup
                                from department in EmployeeDepartmentGroup.DefaultIfEmpty()
                                select new
                                {
                                    EmployeeID = emp?.ID ,
                                    EmployeeName = emp?.Name ?? "NA" ,
                                    DepartmentName = department?.Name ?? "NA",
                                };

            var RightOuterJoin = from dep in Department.GetAllDepartments()
                                 join emp in Employee.GetAllEmployees()
                                 on dep.ID equals emp?.DepartmentId
                                 into DepertmentEmployeeGroup
                                 from employee in DepertmentEmployeeGroup.DefaultIfEmpty()
                                 select new
                                 {
                                     EmployeeID = employee?.ID,
                                     EmployeeName = employee?.Name ?? "NA",
                                     DepartmentName = dep?.Name ?? "NA",
                                 };

            var FullOuterJoin = LeftOuterJoin.Union(RightOuterJoin);

            foreach (var emp in FullOuterJoin)
            {
                Console.WriteLine($"EmployeeId: {emp.EmployeeID}, Name: {emp.EmployeeName}, Department: {emp.DepartmentName}");
            }

        }

        public void Test1() 
        {

            var LeftOuterJoin = Employee.GetAllEmployees().GroupJoin(Department.GetAllDepartments(), emp => emp.DepartmentId, dep => dep.ID, (emp, dep) => new
            {
                emp,
                dep
            }).SelectMany(x => x.dep.DefaultIfEmpty(), (employee, department) => new
            {
                EmployeeID = employee?.emp.ID,
                EmployeeName = employee?.emp.Name ?? "NA",
                DepartmentName = department?.Name ?? "NA"
            });

            var RightOuterJoin = Department.GetAllDepartments().GroupJoin(Employee.GetAllEmployees(), dep => dep.ID, emp => emp.DepartmentId, (dep, emp) => new
            {
                dep,
                emp
            }).SelectMany(x => x.emp.DefaultIfEmpty(), (department, employee) => new
            {
                EmployeeID = employee?.ID,
                EmployeeName = employee?.Name ?? "NA",
                DepartmentName = department.dep.Name ?? "NA",
            });



            var FullOuterJoin = LeftOuterJoin.Union(RightOuterJoin);

            foreach (var emp in FullOuterJoin)
            {
                Console.WriteLine($"EmployeeId: {emp.EmployeeID}, Name: {emp.EmployeeName}, Department: {emp.DepartmentName}");
            }

        }
    }
}
