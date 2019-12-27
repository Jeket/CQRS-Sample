using System.Web.Mvc;

namespace CQRS_Command.Core
{
    public class DefaultCommandBus : ICommandBus
    {
        public void Submit<TCommand>(TCommand command) where TCommand : ICommand
        {
            // command handlers dependency is registerd using UnityConfig.cs file
            var handler = DependencyResolver.Current.GetService<ICommandHandler<TCommand>>();
            if (!((handler != null) && handler is ICommandHandler<TCommand>))
            {
                throw new CommandHandlerNotFoundException(typeof(TCommand));
            }
            handler.Execute(command);
        }
    }
}