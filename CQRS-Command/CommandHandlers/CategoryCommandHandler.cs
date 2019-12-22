using CQRS_Command.Commands;
using CQRS_Command.Core;

namespace CQRS_Command.CommandHandlers
{
    public class CategoryCommandHandler : ICommandHandler<CreateCategoryCommand>,
        ICommandHandler<EditCategoryCommand>
    {
        public ICommandResult Execute(CreateCategoryCommand command)
        {
            // Insert category into database logic here...
            return new CommandResult
            {
                Message = "Category inserted.",
                Success = true
            };
        }

        public ICommandResult Execute(EditCategoryCommand command)
        {
            // Edit category into database logic here...
            return new CommandResult
            {
                Message = "Category edited.",
                Success = true
            };
        }
    }
}