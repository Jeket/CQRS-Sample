using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CQRS_EventSourcing.Core
{
    public interface IEventSubscriber<in TEvent> where TEvent : IEvent
    {
        void Subscribe(TEvent eve);
    }
}