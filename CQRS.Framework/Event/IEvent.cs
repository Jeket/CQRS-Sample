using System;

namespace CQRS.Framework.Event
{
    public interface IEvent
    {
        Guid SourceId { get; set; }
        int Version { get; set; }
        DateTime OccuredOn { get; set; }
    }
}
