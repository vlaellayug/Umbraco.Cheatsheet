using System.Web.Http;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace Umbraco.Cheatsheet.Core.Controllers.ApiControllers
{
    [PluginController("UmbracoCheatsheet")]
    [IsBackOffice]
    public class SampleUmbracoPluginApiController : UmbracoApiController
    {
        //umbraco/backoffice/UmbracoCheatsheet/SampleUmbracoPluginApi/Test
        [HttpGet]
        public IHttpActionResult Test()
        {
            return Json("Usually used when creating packages or content apps.");
        }
    }
}
