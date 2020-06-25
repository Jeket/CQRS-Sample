using CQRS.Framework;
using CQRS.Framework.Event;
using CQRS.Sample.Commands;
using CQRS.Sample.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CQRS.Sample.DomainModels
{
    public class Employee : Aggregate
    {
        #region States
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        #endregion

        public void CreateEmployee(CreateEmployee command)
        {
            this.FirstName = command.FirstName;
            this.LastName = command.LastName;
            this.EmailId = command.EmailId;

            this.Apply(new EmployeeCreated
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                EmailId = command.EmailId,
            });
        }
    }
}