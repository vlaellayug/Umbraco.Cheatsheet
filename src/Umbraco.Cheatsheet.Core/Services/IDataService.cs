using System.Collections.Generic;

namespace Umbraco.Cheatsheet.Core.Services
{
    public interface IDataService
    {
        DataFolder GetDataFolder();
        ProductFolder GetProductFolder();
        IEnumerable<ProductItem> GetProductItems();
    }
}
