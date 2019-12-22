namespace CQRS_Command.Core
{
    // command return no value
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        ICommandResult Execute(TCommand command);
    }
}
