using System;

namespace CQRS_Query.Core
{
    public class QueryProcesserNotFoundException : Exception
    {
        public QueryProcesserNotFoundException(Type queryProcessorType)
        : base(string.Format("Query processor not found for Query {0}.", queryProcessorType.Name))
        {

        }
    }
}