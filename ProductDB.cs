using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    internal class ProductDB
    {

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product product0 = new Product();
            Product product1 = new Product("CB12", "Murach's Java Programming", 57.50m);
            Product product2 = new Product("CB13", "Murach's Android Programming", 77.50m);
            Product product3 = new Product("CB14", "Murach's C# Programming", 59.50m);
            products.Add(product0);
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            return products;
        }
        public static void SaveProducts(List<Product> products)
        {
           
        }

    }
}
