using System.Collections.Generic;
using System.Linq;
using Umbraco.Cheatsheet.Core.Models.ApiModels;

namespace Umbraco.Cheatsheet.Core.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IDataService _dataService;

        public ProductService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IEnumerable<ProductApiModel> GetProducts()
        {
            var products = _dataService.GetProductItems()?
                .Select(productItem => MapProductItem(productItem));

            if (products == null)
                return null;

            return products;
        }

        private ProductApiModel MapProductItem(ProductItem model)
        {
            return new ProductApiModel()
            {
                Label = model.Label,
                Description = model.Description,
                Price = model.Price
            };
        }
    }
}
