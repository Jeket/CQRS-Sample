using System.Web.Mvc;

namespace CQRS.Framework.Event
{
    public class DefaultEventBus : IEventBus
    {
        public void Publish<TEvent>(TEvent eve) where TEvent : IEvent
        {
            var subscribers = DependencyResolver.Current.GetServices<IEventHandler<TEvent>>();
            foreach (var subscriber in subscribers)
            {
                if (!((subscriber != null) && subscriber is IEventHandler<TEvent>))
                {
                    throw new EventHandlerNotFoundException(typeof(TEvent));
                }
                subscriber.Handle(eve);
            }
        }
    }
}