using System;
using System.Collections.Generic;
using System.Text;

namespace web1.Application.Client.ViewModels.Products
{
    public class ProductViewModel// : web1.ViewModels.Products.ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
    }
}
