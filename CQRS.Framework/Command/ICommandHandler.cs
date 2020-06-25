namespace CQRS.Framework.Command
{
    // command returns no value
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
