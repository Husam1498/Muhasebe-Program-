using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;

namespace OMPS.DomainKatmani.Repository
{
    public interface ICommandRepo<T>:IRepository where T : Entity
    {

       
        Task AddAsync(T entity,CancellationToken cancellationToken);

        Task AddRangeAsync(IEnumerable<T> entities,CancellationToken cancellationToken);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entities);
        Task RemoveById(string Id);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);





    }
}
