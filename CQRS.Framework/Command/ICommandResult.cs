using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CQRS.Framework.Command
{
    public class ICommandResult
    {
        HttpStatusCode StatusCode { get; set; }
    }
}
