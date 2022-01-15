using System.Web.Http;
using Umbraco.Web.WebApi;

namespace Umbraco.Cheatsheet.Core.Controllers.ApiControllers
{
    public class SampleUmbracoApiController : UmbracoApiController
    {
        //umbraco/api/SampleUmbracoApi/Test
        [HttpGet]
        public IHttpActionResult Test()
        {
            return Json("Test");
        }
    }
}
