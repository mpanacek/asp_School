using System;
using System.Collections.Generic;
using System.Text;
using web1.Application.Client.ViewModels.Products;
using web1.Domain.Entities.Products;

namespace web1.Application.Admin.Mappers.Products
{
    public interface IProductMapper
    {
        ProductViewModel GetViewModelFromEntity(Product entity);
        Product GetEntityFromViewModel(ProductViewModel viewModel);
        IList<ProductViewModel> GetViewModelsFromEntities(IList<Product> entities);
    }
}
