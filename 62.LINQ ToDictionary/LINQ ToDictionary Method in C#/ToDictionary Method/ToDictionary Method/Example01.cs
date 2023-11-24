using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDictionary_Method
{
    public class Example01
    {

        public class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }


        public void Test()
        {
            List<Product> listProducts = new List<Product>() 
            {
            
            new Product{  ID= 1001, Name = "Mobile", Price = 800 },
            new Product { ID= 1002, Name = "Laptop", Price = 900 },
            new Product { ID= 1003, Name = "Desktop", Price = 800 }

            };

            Dictionary<int, Product> productsDictionary = listProducts.ToDictionary(x=>x.ID);

            foreach (KeyValuePair<int,Product> kvp in productsDictionary)
            {
                Console.WriteLine(kvp.Key + " Name " + kvp.Value.Name + " Price " + kvp.Value.Price);
            }

        }
    }
}
