using CQRS.Framework.CommandBus;
using System.Web.Mvc;

namespace CQRS.Framework
{
    public class BaseCommandController : Controller
    {
        public ICommandBus _bus;
        public BaseCommandController(ICommandBus bus)
        {
            this._bus = bus;
        }
    }
}
