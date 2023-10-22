using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Where_Filtering_Method
{
    public class TWo_Conditions
    {

        public void Test()
        {

           var QuerySyntax = from employee in Employee.GetEmployees()
                             where employee.Salary > 50000 && employee.Gender == "Male"
                             select employee;

          var MethodSyntax = Employee.GetEmployees().Where(x=>x.Salary > 50000 && x.Gender == "Male").ToList();


            foreach (var emp in MethodSyntax)
            {
                Console.WriteLine($"Name : {emp.Name}, Salary : {emp.Salary}, Gender : {emp.Gender}");


                if (emp.Technology !=null && emp.Technology.Count > 0)
                {
                    foreach (var tech in emp.Technology) 
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
    }
}
