using CQRS_Query.Core;
using CQRS_Query.Models;
using CQRS_Query.Queries;
using System.Web.Mvc;

namespace CQRS_Query.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQueryBus _bus;
        public HomeController(IQueryBus bus)
        {
            _bus = bus;
        }

        public ActionResult Index()
        {
            var query = new GetCategoryQuery();
            var result = _bus.Process<Category[], GetCategoryQuery>(query);
            return View();
        }
    }
}