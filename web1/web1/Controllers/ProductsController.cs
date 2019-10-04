using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web1.ViewModels.Products;

namespace web1.Controllers
{
    public class ProductsController : Controller
    {
        private List<ProductViewModel> _products = new List<ProductViewModel>()
        {
            new ProductViewModel { Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel { Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel { Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel { Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel { Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel { Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"}
            /*
            new ProductViewModel { Name = "Snickers", Price = 20M, ImageURL="https://cdn.shopify.com/s/files/1/0972/7116/products/all-city-candy-snickers-peanut-butter-candy-bar-178-oz-candy-bars-mars-chocolate-681780_2048x.jpg?v=1557244225"},
            new ProductViewModel { Name = "Twix", Price = 30M, ImageURL="https://images-na.ssl-images-amazon.com/images/I/71IBchCAjdL._SL1500_.jpg"},
            new ProductViewModel { Name = "Bounty", Price = 40M, ImageURL="https://images-na.ssl-images-amazon.com/images/I/61iAe6wE4RL._SL1000_.jpg"}*/
        };
        public IActionResult Index()
        {
            var vm = new IndexViewModel();
            vm.Products = _products;
            return View(vm);
        }
    }
}