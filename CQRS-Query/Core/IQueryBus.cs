namespace CQRS_Query.Core
{
    public interface IQueryBus
    {
        TResult Process<TResult, TQuery>(TQuery query) where TQuery : IQuery<TResult>;
    }
}
