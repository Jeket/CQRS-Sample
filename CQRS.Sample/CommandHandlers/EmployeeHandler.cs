using CQRS.Sample.Commands;
using CQRS.Sample.DomainModels;
using CQRS.Sample.Events;
using System;

namespace CQRS.Sample.CommandHandlers
{
    public class EmployeeHandler : IEmployeeCommandHander
    {
        public void Handle(CreateEmployee command)
        {
            var employee = new Employee()
            {
                EmailId = command.EmailId,
                FirstName = command.FirstName,
                LastName = command.LastName
            };
            employee.Apply(new EmployeeCreated() {
                EmailId = command.EmailId,
                FirstName = command.FirstName,
                LastName = command.LastName
            });
        }

        public void Handle(ChangeFirstName command)
        {
            // Fetch Employee by Id from database and apply FirstNameChanged event.
            throw new NotImplementedException();
        }

        public void Handle(ChangeLastName command)
        {
            throw new NotImplementedException();
        }

        public void Handle(ChangeEmailId command)
        {
            throw new NotImplementedException();
        }
    }
}