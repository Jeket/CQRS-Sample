using System.Net;

namespace CQRS.Framework.CommandBus
{
    public interface ICommandResult
    {
        HttpStatusCode StatusCode { get; set; }
    }
}
