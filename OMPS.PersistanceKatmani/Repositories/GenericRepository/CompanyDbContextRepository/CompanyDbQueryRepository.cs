using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository.CompanyDbContext;
using System.Linq.Expressions;

namespace OMPS.PersistanceKatmani.Repositories
{
    public class CompanyDbQueryRepository<T> : ICompanyDbQueryRepo<T> where T : Entity
    {
        private static readonly Func<Context.CompanyDbContext, string,bool, Task<T>>
            GetbyIdCompiled = EF.CompileAsyncQuery((Context.CompanyDbContext context, string id,bool isTracking) =>
               isTracking==true ? context.Set<T>().FirstOrDefault(p => p.Id == id) : context.Set<T>().AsNoTracking().FirstOrDefault(p => p.Id == id));

        private static readonly Func<Context.CompanyDbContext,bool, Task<T>>
          GetbyFirstCompiled = EF.CompileAsyncQuery((Context.CompanyDbContext context,bool isTracking) =>
             isTracking==true ? context.Set<T>()
              .FirstOrDefault() : context.Set<T>().AsNoTracking()
              .FirstOrDefault());

       

        private Context.CompanyDbContext _context;

        public void CreateDbContextInstance(DbContext context)
        {
            _context= (Context.CompanyDbContext)context;
        }

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

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression,CancellationToken cancellationToken, bool IsTracking = true)
        {
            T entity = null;
            if (!IsTracking)
            {
                entity = await _context.Set<T>().AsNoTracking().Where(expression).FirstOrDefaultAsync();
            }
            else
            {
                entity = await _context.Set<T>().Where(expression).FirstOrDefaultAsync();
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
