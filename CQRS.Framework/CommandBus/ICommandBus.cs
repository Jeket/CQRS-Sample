using CQRS.Framework.Command;

namespace CQRS.Framework.CommandBus
{
    public interface ICommandBus
    {
        ICommandResult Submit<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
