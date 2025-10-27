using OMPS.DomainKatmani.Abstractions;

namespace OMPS.DomainKatmani.Repository.GenericRepository
{
    //Generic olan diğer interfacelerin ortak kullandığı alanlar
    public  interface ICommandGenericRepository<T> where T : Entity
    {
        Task AddAsync(T entity, CancellationToken cancellationToken);

        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entities);
        Task RemoveById(string Id);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
