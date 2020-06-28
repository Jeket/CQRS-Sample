using CQRS.Framework.ReadModel;

namespace CQRS.Web.ReadModels
{
    public class Employee : BaseReadModel
    {
        public string Name { get; set; }
    }
}