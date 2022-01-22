using System.Web.Http;
using Umbraco.Cheatsheet.Core.Services;
using Umbraco.Web.WebApi;

namespace Umbraco.Cheatsheet.Core.Controllers.ApiControllers
{
    public class ProductApiController : UmbracoApiController
    {
        private readonly IProductService _productService;

        public ProductApiController(IProductService productService)
        {
            _productService = productService;
        }

        //umbraco/api/ProductApi/Products
        [HttpGet]
        public IHttpActionResult Products()
        {
            var products = _productService.GetProducts();

            if (products == null)
                return BadRequest("No products found.");

            return Json(products);
        }
    }
}
