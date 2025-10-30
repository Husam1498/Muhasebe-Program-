using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository.AppDbContext;
using System.Linq.Expressions;

namespace OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository
{
    public class AppQueryRepository<T> : IAppQueryRepository<T> where T : Entity
    {
      
            private static readonly Func<Context.AppDbContext, string, bool, Task<T>>
                GetbyIdCompiled = EF.CompileAsyncQuery((Context.AppDbContext context, string id, bool isTracking) =>
                   isTracking == true ? context.Set<T>().FirstOrDefault(p => p.Id == id) : context.Set<T>().AsNoTracking().FirstOrDefault(p => p.Id == id));

            private static readonly Func<Context.AppDbContext, bool, Task<T>>
              GetbyFirstCompiled = EF.CompileAsyncQuery((Context.AppDbContext context, bool isTracking) =>
                 isTracking == true ? context.Set<T>()
                  .FirstOrDefault() : context.Set<T>().AsNoTracking()
                  .FirstOrDefault());

   

            private Context.AppDbContext _context;

        public AppQueryRepository(Context.AppDbContext context)
        {
            _context = context;
            Entity=_context.Set<T>();
        }

        public DbSet<T> Entity { get ; set ; }

        public IQueryable<T> GetAll(bool IsTracking = true)
            {
                var result = _context.Set<T>().AsQueryable();
                if (!IsTracking)
                    result = result.AsNoTracking();
                return result;
            }

            public async Task<T> GetById(string Id, bool IsTracking = true)
            {
                return await GetbyIdCompiled(_context, Id, IsTracking);
            }

            public async Task<T> GetFirst(bool IsTracking = true)
            {
                return await GetbyFirstCompiled(_context, IsTracking);
            }

            public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, CancellationToken cancellationToken, bool IsTracking = true)
            {
                T entity = null;
                if (!IsTracking)
                {
                     entity = await Entity.AsNoTracking().Where(expression).FirstOrDefaultAsync(cancellationToken);
                }
                else
                {
                    entity = await Entity.Where(expression).FirstOrDefaultAsync(cancellationToken);
                }
                return entity;
            }

            public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool IsTracking = true)
            {
                var result = _context.Set<T>().Where(expression);
                if (!IsTracking)
                    result = result.AsNoTracking();

                return result;
            }
        }
}
