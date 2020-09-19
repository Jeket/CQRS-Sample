using CQRS.Framework.ReadModel;
using System;

namespace CQRS.Web.ReadModels
{
    public class Employee : BaseReadModel
    {
        public Guid AggregateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}