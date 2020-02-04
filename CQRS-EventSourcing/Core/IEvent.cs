using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_EventSourcing.Core
{
    public interface IEvent
    {
        DateTime OccuredOn { get; set; }
    }
}
