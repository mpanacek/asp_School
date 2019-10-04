using System;
using System.Collections.Generic;
using System.Text;

namespace web1.Domain.Entities.Products
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
    }
}
