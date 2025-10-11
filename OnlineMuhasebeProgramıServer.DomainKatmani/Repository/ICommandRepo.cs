using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;

namespace OMPS.DomainKatmani.Repository
{
    public interface ICommandRepo<T>:IRepository where T : Entity
    {

       
        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entities);
        Task RemoveById(string Id);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);





    }
}
