using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_EventSourcing.Core
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent eve) where TEvent : IEvent;
    }
}
