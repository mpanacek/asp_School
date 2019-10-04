using System.Collections.Generic;
using web1.Domain.Entities.Products;

namespace web1.Domain.Services.Products
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
