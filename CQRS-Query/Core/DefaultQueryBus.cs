using System.Web.Mvc;

namespace CQRS_Query.Core
{
    public class DefaultQueryBus : IQueryBus
    {
        public TResult Process<TResult, TQuery>(TQuery query) where TQuery : IQuery<TResult>
        {
            // query handlers dependency is registerd using UnityConfig.cs file
            var handler = DependencyResolver.Current.GetService<IQueryHandler<TQuery, TResult>>();
            if (!((handler != null) && handler is IQueryHandler<TQuery, TResult>))
            {
                throw new QueryHandlerNotFoundException(typeof(TQuery));
            }
            return handler.Process(query);
        }
    }
}