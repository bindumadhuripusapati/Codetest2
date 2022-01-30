using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI
{
//    a) Properties:
//i) ProductName : string
//ii) Price: decimal
//iii) Description: string
//b) Constructor that sets the above properti
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Product(string _ProductName, decimal _Price,string _Description)
        {
            ProductName = _ProductName;
            Price = _Price;
            Description = _Description;
        }
    }
}
