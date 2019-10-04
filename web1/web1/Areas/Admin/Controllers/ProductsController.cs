using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web1.Areas.Admin.ViewModels.Products;

namespace web1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private List<ProductViewModel> _products = new List<ProductViewModel>()
        {
            new ProductViewModel {ID = 1, Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel {ID = 2, Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel {ID = 3, Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel {ID = 4, Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel {ID = 5, Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"},
            new ProductViewModel {ID = 6, Name = "Mars", Price = 10M, ImageURL="https://d25-a.sdn.szn.cz/d_25/d_15041729/img/31/759x233_OEfcaA.jpg"}
        };
        public IActionResult Index()
        {
            var vm = new IndexViewModel();
            vm.Products = _products;
            return View(vm);
        }

        public IActionResult Edit(int id)
        {
            var vm = _products.Single(x => x.ID == id);
            return View(vm);
        }

        public IActionResult Delete(int id)
        {
            var product = _products.Single(x => x.ID == id);
            _products.Remove(product);

            return RedirectToAction(nameof(Index));
        }
    }
}