using System;

namespace CQRS.Framework.EventBus
{
    public class EventHandlerNotFoundException : Exception
    {
        public EventHandlerNotFoundException(Type eventPublisherType)
        : base(string.Format("Event handler not found for event {0}.", eventPublisherType.Name))
        {

        }
    }
}