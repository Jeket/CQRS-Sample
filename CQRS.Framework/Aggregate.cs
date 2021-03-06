﻿using CQRS.Framework.Event;
using CQRS.Framework.EventBus;
using System;
using System.Web.Mvc;

namespace CQRS.Framework
{
    public class Aggregate
    {
        private IEventBus _bus;

        public Aggregate()
        {
            _bus = DependencyResolver.Current.GetService<IEventBus>();
        }

        public Guid AggregateId { get; protected set; }
        public int Version { get; protected set; }

        public void Apply(IEvent @event)
        {
            @event.SourceId = this.AggregateId;
            @event.Version = this.Version + 1;
            this._bus.Publish(@event);
        }
    }
}
