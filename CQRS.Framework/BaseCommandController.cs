using CQRS.Framework.Command;
using System.Web.Http;

namespace CQRS.Framework
{
    public class BaseCommandController : ApiController
    {
        public ICommandBus _bus;
        public BaseCommandController(ICommandBus bus)
        {
            this._bus = bus;
        }
    }
}
