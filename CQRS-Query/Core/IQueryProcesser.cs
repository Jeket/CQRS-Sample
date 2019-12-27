namespace CQRS_Query.Core
{
    public interface IQueryProcesser<TQuery, TResult>
    where TQuery : IQuery<TResult>
    {
        TResult Process(TQuery query);
    }
}
