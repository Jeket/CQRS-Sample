using CQRS_EventSourcing.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CQRS_EventSourcing.Events
{
    public class CategoryCreatedEvent : IEvent
    {
        public CategoryCreatedEvent(int CategoryId)
        {
            this.CategoryId = CategoryId;
            this.OccuredOn = DateTime.Now;
        }
        public int CategoryId { get; set; }
        public DateTime OccuredOn { get; set; }
    }
}