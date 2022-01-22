using System.Web.Mvc;
using Umbraco.Cheatsheet.Core.Models.ViewModels;
using Umbraco.Cheatsheet.Core.Services;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.Cheatsheet.Core.Controllers.RenderMvcControllers
{
    public class DashboardPageController : RenderMvcController
    {
        private readonly IDataService _dataService;

        public DashboardPageController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public override ActionResult Index(ContentModel model)
        {
            var vm = new DashboardVm(model.Content);
            vm.Products = _dataService.GetProductItems();

            return CurrentTemplate(vm);
        }
    }
}
