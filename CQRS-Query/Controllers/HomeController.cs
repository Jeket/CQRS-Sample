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
            // 1. Create Query
            // 2. Pass query to QueryBus
            // 3. QueryBus will create object of query processer
            // 4. Query processer will process query and return value
            var query = new GetCategoryQuery();
            var result = _bus.Process<Category[], GetCategoryQuery>(query);
            return View();
        }
    }
}