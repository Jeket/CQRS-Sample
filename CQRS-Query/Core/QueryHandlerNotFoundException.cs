using System;

namespace CQRS_Query.Core
{
    public class QueryHandlerNotFoundException : Exception
    {
        public QueryHandlerNotFoundException(Type queryHandlerType)
        : base(string.Format("Query handler not found for Query {0}.", queryHandlerType.Name))
        {

        }
    }
}