using System.Web.Mvc;

namespace CQRS_Query.Core
{
    public class DefaultQueryBus : IQueryBus
    {
        public TResult Process<TResult, TQuery>(TQuery query) where TQuery : IQuery<TResult>
        {
            // query processer dependency is registerd using UnityConfig.cs file
            var processor = DependencyResolver.Current.GetService<IQueryProcesser<TQuery, TResult>>();
            if (!((processor != null) && processor is IQueryProcesser<TQuery, TResult>))
            {
                throw new QueryProcesserNotFoundException(typeof(TQuery));
            }
            return processor.Process(query);
        }
    }
}