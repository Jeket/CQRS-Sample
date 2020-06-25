using System;

namespace CQRS.Framework.Event
{
    public class Event : IEvent
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public DateTime OccuredOn { get; set; }
    }
}
