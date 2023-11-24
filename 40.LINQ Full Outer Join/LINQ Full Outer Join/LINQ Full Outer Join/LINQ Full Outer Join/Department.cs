using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Full_Outer_Join
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 10, Name = "IT"       },
                new Department { ID = 20, Name = "HR"       },
                new Department { ID = 30, Name = "Payroll"  },
                new Department { ID = 40, Name = "Admin"    },
                new Department { ID = 40, Name = "Sales"    }
            };
        }
    }
}
