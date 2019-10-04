using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using web1.Application.Admin.Mappers.Products;
using web1.Application.Client.ViewModels.Products;
using web1.Domain.Services.Products;

namespace web1.Application.Admin.ApplicationServices.Products
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductMapper _productMapper;
        private readonly IProductService _productService;

        public ProductApplicationService(IProductMapper mapper, IProductService productService)
        {
            _productMapper = mapper;
            _productService = productService;
        }

        public ProductViewModel GetProductViewModel(int id)
        {
           
            //return _productMapper.Map<ProductViewModel>(id);
        }

        public IndexViewModel GetIndexViewModel()
        {
            return new IndexViewModel
            {
                Products = _productMapper.GetViewModelsFromEntities(_productService.GetAll()).ToList()
            };
        }
    }
}
