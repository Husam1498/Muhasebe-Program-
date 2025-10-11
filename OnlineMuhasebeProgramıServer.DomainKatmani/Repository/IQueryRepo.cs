using OMPS.DomainKatmani.Abstractions;
using System.Linq.Expressions;

namespace OMPS.DomainKatmani.Repository
{
    public interface IQueryRepo<T>:IRepository where T : Entity
    {

        IQueryable<T> GetAll();

        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);

        Task<T> GetById(string Id);
        Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression);

        Task<T> GetFirst();



    }
}
