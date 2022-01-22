using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace Umbraco.Cheatsheet.Core.Models.ViewModels
{
    public class DashboardViewModel : ContentModel
    {
        public DashboardViewModel(IPublishedContent content) : base(content)
        {
        }

        public IEnumerable<ProductItem> Products { get; set; }
    }
}
