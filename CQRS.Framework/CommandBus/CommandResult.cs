using System.Net;

namespace CQRS.Framework.CommandBus
{
    public class CommandResult : ICommandResult
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
