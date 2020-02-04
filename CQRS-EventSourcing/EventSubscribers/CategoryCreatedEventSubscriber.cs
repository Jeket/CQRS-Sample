using CQRS_EventSourcing.Core;
using CQRS_EventSourcing.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CQRS_EventSourcing.EventSubscribers
{
    public class CategoryCreatedEventSubscriber : IEventSubscriber<CategoryCreatedEvent>
    {
        public void Subscribe(CategoryCreatedEvent eve)
        {
            // New Category is created.
        }
    }
}