namespace CQRS.Framework.Event
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent eve) where TEvent : IEvent;
    }
}
