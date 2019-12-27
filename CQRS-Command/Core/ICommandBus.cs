namespace CQRS_Command.Core
{
    public interface ICommandBus
    {
        void Submit<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
