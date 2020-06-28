using System;

namespace CQRS.Framework.ReadModel
{
    public class BaseReadModel
    {
        public Guid AggregateId { get; set; }
        public int Version { get; set; }
    }
}
