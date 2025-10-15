using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository;
using OMPS.PersistanceKatmani.Context;

namespace OMPS.PersistanceKatmani.Repositories
{
    public class CommandRepository<T> : ICommandRepo<T> where T : Entity
    {
        private static readonly Func<CompanyDbContext, string, Task<T>>
            GetbyIdCompiled = EF.CompileAsyncQuery((CompanyDbContext context, string id) =>
                context.Set<T>()
                .FirstOrDefault(p => p.Id == id));

        private  CompanyDbContext _context;

        public void CreateDbContextInstance(DbContext context)
        {
           _context = (CompanyDbContext)context;
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await _context.Set<T>().AddAsync(entity,cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            await _context.Set<T>().AddRangeAsync(entities,cancellationToken);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task RemoveById(string Id)
        {
            T entity = await GetbyIdCompiled(_context, Id);
            Remove(entity);

        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
           _context.Set<T>().UpdateRange(entities);
        }

    }
}
