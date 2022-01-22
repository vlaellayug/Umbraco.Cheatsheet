using System.Collections.Generic;
using Umbraco.Cheatsheet.Core.Models.ApiModels;

namespace Umbraco.Cheatsheet.Core.Services
{
    public interface IProductService
    {
        IEnumerable<ProductApiModel> GetProducts();
    }
}
