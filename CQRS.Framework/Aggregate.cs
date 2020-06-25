using CQRS.Framework.Event;
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

        public Guid Id { get; protected set; }
        public int Version { get; protected set; }

        public void Apply(IEvent eve)
        {
            eve.Id = this.Id;
            eve.Version = this.Version + 1;
            this._bus.Publish(eve);
        }
    }
}
