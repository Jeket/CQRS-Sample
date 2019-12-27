namespace CQRS_Command.Core
{
    // command returns no value
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}
