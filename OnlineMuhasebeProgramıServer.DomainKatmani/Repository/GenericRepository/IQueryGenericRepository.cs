using OMPS.DomainKatmani.Abstractions;
using System.Linq.Expressions;

namespace OMPS.DomainKatmani.Repository.GenericRepository
{
    public  interface IQueryGenericRepository<T> where T : Entity
    {
        IQueryable<T> GetAll(bool IsTracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool IsTracking = true);
        Task<T> GetById(string Id, bool IsTracking = true);
        Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression,CancellationToken cancellationToken, bool IsTracking = true);
        Task<T> GetFirst(bool IsTracking = true);
    }
}
