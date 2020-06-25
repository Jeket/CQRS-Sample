using CQRS.Framework.Event;

namespace CQRS.Sample.Events
{
    public class EmployeeCreated : Event
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
    }

    public class FirstNameChanged : Event
    {
        public string FirstName { get; set; }
    }

    public class LastNameChanged : Event
    {
        public string LastName { get; set; }
    }

    public class EmailIdChanged : Event
    {
        public string EmailId { get; set; }
    }

    public interface IEmployeeEventHander :
        IEventHandler<EmployeeCreated>,
        IEventHandler<FirstNameChanged>,
        IEventHandler<LastNameChanged>,
        IEventHandler<EmailIdChanged>
    { }
}