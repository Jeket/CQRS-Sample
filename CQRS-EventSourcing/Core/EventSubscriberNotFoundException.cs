using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CQRS_EventSourcing.Core
{
    public class EventSubscriberNotFoundException : Exception
    {
        public EventSubscriberNotFoundException(Type eventPublisherType)
        : base(string.Format("Event subscriber not found for event {0}.", eventPublisherType.Name))
        {

        }
    }
}