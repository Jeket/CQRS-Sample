using CQRS.Framework.Command;
using System.Web.Mvc;

namespace CQRS.Framework.CommandBus
{
    public class DefaultCommandBus : ICommandBus
    {
        public ICommandResult Submit<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = DependencyResolver.Current.GetService<ICommandHandler<TCommand>>();
            if (!((handler != null) && handler is ICommandHandler<TCommand>))
            {
                throw new CommandHandlerNotFoundException(typeof(TCommand));
            }
            handler.Handle(command);

            return new CommandResult
            {
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
    }
}