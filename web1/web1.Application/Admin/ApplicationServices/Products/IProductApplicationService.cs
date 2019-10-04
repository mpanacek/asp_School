using System;
using System.Collections.Generic;
using System.Text;
using web1.Application.Client.ViewModels.Products;

namespace web1.Application.Admin.ApplicationServices.Products
{
    public interface IProductApplicationService
    {
        IndexViewModel GetIndexViewModel();
        ProductViewModel GetProductViewModel(int id);
    }
}
