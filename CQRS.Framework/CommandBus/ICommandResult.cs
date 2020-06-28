using System.Net;

namespace CQRS.Framework.CommandBus
{
    public class ICommandResult
    {
        HttpStatusCode StatusCode { get; set; }
    }
}
