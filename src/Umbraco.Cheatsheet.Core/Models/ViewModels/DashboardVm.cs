using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace Umbraco.Cheatsheet.Core.Models.ViewModels
{
    public class DashboardVm : ContentModel
    {
        public DashboardVm(IPublishedContent content) : base(content)
        {
        }

        public IEnumerable<ProductItem> Products { get; set; }
    }
}
