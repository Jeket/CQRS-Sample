using CQRS.Framework.Event;

namespace CQRS.Framework.EventBus
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
