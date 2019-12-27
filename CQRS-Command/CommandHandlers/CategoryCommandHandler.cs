using CQRS_Command.Commands;
using CQRS_Command.Core;

namespace CQRS_Command.CommandHandlers
{
    public class CategoryCommandHandler : ICommandHandler<CreateCategoryCommand>,
        ICommandHandler<EditCategoryCommand>
    {
        public void Execute(CreateCategoryCommand command)
        {
            // Insert category into database logic here...
        }

        public void Execute(EditCategoryCommand command)
        {
            // Edit category into database logic here...
        }
    }
}