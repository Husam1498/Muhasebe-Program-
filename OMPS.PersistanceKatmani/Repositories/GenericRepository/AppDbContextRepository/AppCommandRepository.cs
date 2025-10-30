using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository.AppDbContext;

namespace OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository
{
    public class AppCommandRepository<T> : IAppCommandRepository<T> where T : Entity
    {
        private readonly Context.AppDbContext _context;

        public AppCommandRepository(Context.AppDbContext context)
        {
            _context = context;
            Entity=_context.Set<T>();//entity içerine  _context.Set<T>() bunu attık artık her enitityi çağırdığımızda bunu kullanabiliiriz

        }

        public DbSet<T> Entity { get; set; }

        private static readonly Func<Context.AppDbContext, string, Task<T>>
            GetbyIdCompiled = EF.CompileAsyncQuery((Context.AppDbContext context, string id) =>
                context.Set<T>()
                .FirstOrDefault(p => p.Id == id));

        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await _context.Set<T>().AddAsync(entity, cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            await _context.Set<T>().AddRangeAsync(entities, cancellationToken);
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
