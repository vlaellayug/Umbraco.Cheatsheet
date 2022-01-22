using System.Collections.Generic;
using System.Linq;
using Umbraco.Web;

namespace Umbraco.Cheatsheet.Core.Services.Implementation
{
    public class DataService : IDataService
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;

        public DataService(IUmbracoContextAccessor umbracoContextAccessor)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
        }

        public DataFolder GetDataFolder()
        {
            var dataFolder = _umbracoContextAccessor.UmbracoContext
                .Content
                .GetAtRoot()?
                .OfType<DataFolder>()?
                .FirstOrDefault();

            return dataFolder;
        }

        public ProductFolder GetProductFolder()
        {
            var productFolder = GetDataFolder()?.Children<ProductFolder>()?
                .FirstOrDefault();

            return productFolder;
        }

        public IEnumerable<ProductItem> GetProductItems()
        {
            var productItems = GetProductFolder()?.Children<ProductItem>();

            return productItems;
        }
    }
}
