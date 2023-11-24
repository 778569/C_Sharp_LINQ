using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paging_Skip_Take
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee() {ID = 1, Name = "Kavinda", Department = "IT" },
                new Employee() {ID = 2, Name = "Buddhika", Department = "IT" },
                new Employee() {ID = 3, Name = "Bandara", Department = "IT" },
                new Employee() {ID = 4, Name = "Shakuni", Department = "IT" },
                new Employee() {ID = 5, Name = "Salmaan", Department = "HR" },
                new Employee() {ID = 6, Name = "Umair", Department = "HR" },
                new Employee() {ID = 7, Name = "Kamal", Department = "HR" },
                new Employee() {ID = 8, Name = "Nimal", Department = "IT" },
                new Employee() {ID = 9, Name = "Sunil", Department = "IT" },
                new Employee() {ID = 10, Name = "Babu", Department = "IT" },
                new Employee() {ID = 11, Name = "Himal", Department = "HR" },
                new Employee() {ID = 12, Name = "Saman", Department = "HR" },
                new Employee() {ID = 13, Name = "Udaya", Department = "HR" },
                new Employee() {ID = 14, Name = "Ishan", Department = "HR" },
                new Employee() {ID = 15, Name = "Sachin", Department = "IT" },
                new Employee() {ID = 16, Name = "Andrus", Department = "IT" },
            };
        }
    }
}
