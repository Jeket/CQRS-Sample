namespace CQRS.Framework.Event
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}