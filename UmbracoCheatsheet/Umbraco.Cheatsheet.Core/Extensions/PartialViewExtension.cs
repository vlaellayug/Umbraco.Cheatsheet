using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Mvc;

namespace Umbraco.Cheatsheet.Core.Extensions
{
    public static class PartialViewExtension
    {
        public static void RenderElement<T>(this UmbracoViewPage<T> page, IPublishedElement element, string folder = null, ViewDataDictionary viewData = null)
        {
            if (element != null)
            {
                var folderString = folder == null ? "" : folder + "/";
                var partialView = $"{folderString}{element.ContentType.Alias}";
                page.Html.RenderPartial(partialView, element, viewData);
            }
        }

        public static void RenderElements<T>(this UmbracoViewPage<T> page, IEnumerable<IPublishedElement> elements, string folder = null)
        {
            if (elements == null || !elements.Any())
            {
                return;
            }
            foreach (var element in elements)
            {
                page.RenderElement(element, folder, new ViewDataDictionary { { "Elements", elements }, { "ViewModel", page.Model } });
            }
        }
    }
}
