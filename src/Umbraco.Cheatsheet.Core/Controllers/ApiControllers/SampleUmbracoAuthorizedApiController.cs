using System.Web.Http;
using Umbraco.Web.WebApi;

namespace Umbraco.Cheatsheet.Core.Controllers.ApiControllers
{
    public class SampleUmbracoAuthorizedApiController : UmbracoAuthorizedApiController
    {
        //umbraco/backoffice/api/SampleUmbracoAuthorizedApi/Test
        [HttpGet]
        public IHttpActionResult Test()
        {
            return Json("Only users who are logged in the backoffice can only access this api.");
        }
    }
}
