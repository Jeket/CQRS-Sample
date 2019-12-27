using CQRS_Command.Commands;
using CQRS_Command.Core;
using System.Web.Mvc;

namespace CQRS_Command.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICommandBus _bus;
        public HomeController(ICommandBus bus)
        {
            _bus = bus;
        }

        public ActionResult Index()
        {
            // 1. Create Command
            // 2. Pass command to CommandBus
            // 3. CommandBus will create object of command handler
            // 4. Command handler will handle command
            var createCategory = new CreateCategoryCommand(1, "Test", "Test Description");
            _bus.Submit(createCategory);

            var editCategory = new EditCategoryCommand(1, "Test", "Test Description");
            _bus.Submit(editCategory);

            return View();
        }
    }
}