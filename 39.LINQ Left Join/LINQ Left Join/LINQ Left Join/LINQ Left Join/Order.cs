using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Left_Join
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public static List<Order> OrderList()
        {
            List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 101, CustomerId = 10101, OrderDate = DateTime.Parse("2022-05-10") },
                new Order { OrderId = 102, CustomerId = 10102, OrderDate = DateTime.Parse("2022-05-15") },
                new Order { OrderId = 103, CustomerId = 10103, OrderDate = DateTime.Parse("2022-05-20") },
            };
            return orders;
        }
    }
}
