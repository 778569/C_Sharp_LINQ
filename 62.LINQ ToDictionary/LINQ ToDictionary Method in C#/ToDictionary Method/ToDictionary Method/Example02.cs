using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ToDictionary_Method.Example01;

namespace ToDictionary_Method
{
    public class Example02
    {
        public void Test()
        {
            List<Product> listProducts = new List<Product>
            {
                new Product { ID= 1001, Name = "Mobile", Price = 800 },
                new Product { ID= 1002, Name = "Laptop", Price = 900 },
                new Product { ID= 1003, Name = "Desktop", Price = 800 }
            };

            Dictionary<int, string> productsDictionary = listProducts.ToDictionary(x => x.ID, x => x.Name);

            foreach (KeyValuePair<int,string> kvp in productsDictionary)
            {

                Console.WriteLine("Key : " + kvp.Key + " Value " + kvp.Value);
            }
        }
    }
}
