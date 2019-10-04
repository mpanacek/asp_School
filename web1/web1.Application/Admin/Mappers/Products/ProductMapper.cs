using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using web1.Application.Client.ViewModels.Products;
using web1.Domain.Entities.Products;

namespace web1.Application.Admin.Mappers.Products
{
    public class ProductMapper : IProductMapper
    {
        private readonly IMapper _mapper;

        public ProductMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Product GetEntityFromViewModel(ProductViewModel viewModel)
        {
            return _mapper.Map<Product>(viewModel);
        }

        public ProductViewModel GetViewModelFromEntity(Product entity)
        {
            return _mapper.Map<ProductViewModel>(entity);
        }

        public IList<ProductViewModel> GetViewModelsFromEntities(IList<Product> entities)
        {
            return _mapper.Map<IList<ProductViewModel>>(entities);
        }
    }
}
