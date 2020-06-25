using System.Web.Mvc;

namespace CQRS.Framework.Command
{
    public class DefaultCommandBus : ICommandBus
    {
        public ICommandResult Submit<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handlers = DependencyResolver.Current.GetServices<ICommandHandler<TCommand>>();
            foreach (var handler in handlers)
            {
                if (!((handler != null) && handler is ICommandHandler<TCommand>))
                {
                    throw new CommandHandlerNotFoundException(typeof(TCommand));
                }
                handler.Handle(command);
            }

            return new CommandResult
            {
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
    }
}