namespace CQRS_Command.Core
{
    public class CommandResult: ICommandResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}