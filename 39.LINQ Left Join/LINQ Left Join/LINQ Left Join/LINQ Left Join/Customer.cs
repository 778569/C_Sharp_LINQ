using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Left_Join
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public static List<Customer> GetCustomer()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerId = 10101, Name = "Pranaya" },
                new Customer { CustomerId = 10103, Name = "Rout" },
            };
            return customers;
        }
    }
}
