using CQRS.Framework;
using CQRS.Framework.Command;
using CQRS.Sample.Commands;

namespace CQRS.Sample.Controllers
{
    public class EmployeeController : BaseCommandController
    {
        public EmployeeController(ICommandBus bus) : base(bus)
        { }

        public ICommandResult CreateEmployee(CreateEmployee command)
        {
            return _bus.Submit(command);
        }

        public ICommandResult ChangeFirstName(ChangeFirstName command)
        {
            return _bus.Submit(command);
        }

        public ICommandResult ChangeLastName(ChangeLastName command)
        {
            return _bus.Submit(command);
        }

        public ICommandResult ChangeEmailId(ChangeEmailId command)
        {
            return _bus.Submit(command);
        }
    }
}
