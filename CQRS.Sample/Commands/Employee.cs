using CQRS.Framework.Command;
using System;

namespace CQRS.Sample.Commands
{
    public class CreateEmployee : Command
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
    }

    public class ChangeFirstName : Command
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string FirstName { get; set; }
    }

    public class ChangeLastName : Command
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string LastName { get; set; }
    }

    public class ChangeEmailId : Command
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string EmailId { get; set; }
    }

    public interface IEmployeeCommandHander :
        ICommandHandler<CreateEmployee>,
        ICommandHandler<ChangeFirstName>,
        ICommandHandler<ChangeLastName>,
        ICommandHandler<ChangeEmailId>
    { }
}