using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paging_Skip_Take
{
    public class PagingExample
    {
        public void Test()
        {
            //List<Employee> employees = Employee.GetAllEmployees();


            int PageNumber = 0;
            int RecordsPerPage = 4;

            //Read the Value and if its integer type, then store that value in the PageNumber variable
            //var Paging_Result = employees.Skip((PN - 1)*NRP).Take(NRP).ToList();
            Console.WriteLine("\nEnter the Page Number Between 1 and 4");
            do
            {
                if (int.TryParse(Console.ReadLine(), out PageNumber))
                {
                    if (PageNumber > 0 && PageNumber < 5)
                    {

                        var employees = Employee.GetAllEmployees() //Data Source
                                    .Skip((PageNumber - 1) * RecordsPerPage) //Skip Logic
                                    .Take(RecordsPerPage).ToList(); //Take Logic
                        Console.WriteLine();
                        Console.WriteLine("Page Number : " + PageNumber);
                        foreach (var emp in employees)
                        {
                            Console.WriteLine($"ID : {emp.ID}, Name : {emp.Name}, Department : {emp.Department}");
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nPlease Enter a Valid Page Number");
                    }
                }


                Console.WriteLine("\nEnter the Page Number Between 1 and 4");


            } while (true);
        }
    }
}
