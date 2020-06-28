using CQRS.Framework.Event;

namespace CQRS.Framework.EventBus
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent eve) where TEvent : IEvent;
    }
}
