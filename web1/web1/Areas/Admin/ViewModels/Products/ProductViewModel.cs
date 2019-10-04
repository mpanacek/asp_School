using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web1.Areas.Admin.ViewModels.Products
{
    public class ProductViewModel : web1.ViewModels.Products.ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
    }
}
