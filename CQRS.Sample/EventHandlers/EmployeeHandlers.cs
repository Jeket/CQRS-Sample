using CQRS.Sample.Events;
using System;

namespace CQRS.Sample.EventHandlers
{
    public class EmployeeHandlers : IEmployeeEventHander
    {
        public void Handle(EmployeeCreated eve)
        {
            throw new NotImplementedException();
            // Logic to update data in database
        }

        public void Handle(FirstNameChanged eve)
        {
            throw new NotImplementedException();
        }

        public void Handle(LastNameChanged eve)
        {
            throw new NotImplementedException();
        }

        public void Handle(EmailIdChanged eve)
        {
            throw new NotImplementedException();
        }
    }
}