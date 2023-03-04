using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Product
    {
        private string code;
        private string description;
        private decimal price;
        public Product()
        {
            this.code = "CC12";
            this.description = "Flutter";
            this.price = 50.00m;
        }

        public Product(string code, string description, decimal price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string GetDisplayText(string sep)
        {
            return code + sep + description + sep + price.ToString("c");
        }
    }
}
