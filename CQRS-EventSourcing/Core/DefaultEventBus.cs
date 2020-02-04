using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CQRS_EventSourcing.Core
{
    public class DefaultEventBus : IEventBus
    {
        public void Publish<TEvent>(TEvent eve) where TEvent : IEvent
        {
            // event subscribe dependency is registerd using UnityConfig.cs file
            var subscribers = DependencyResolver.Current.GetService<IEventSubscriber<TEvent>>();
            if (!((subscribers != null) && subscribers is IEventSubscriber<TEvent>))
            {
                throw new EventSubscriberNotFoundException(typeof(TEvent));
            }
            subscribers.Subscribe(eve);
        }
    }
}