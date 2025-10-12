using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository;
using OMPS.PersistanceKatmani.Context;
using System.Linq.Expressions;

namespace OMPS.PersistanceKatmani.Repositories
{
    public class QueryRepository<T> : IQueryRepo<T> where T : Entity
    {
        private static readonly Func<CompanyDbContext, string,bool, Task<T>>
            GetbyIdCompiled = EF.CompileAsyncQuery((CompanyDbContext context, string id,bool isTracking) =>
               isTracking==true ? context.Set<T>().FirstOrDefault(p => p.Id == id) : context.Set<T>().AsNoTracking().FirstOrDefault(p => p.Id == id));

        private static readonly Func<CompanyDbContext,bool, Task<T>>
          GetbyFirstCompiled = EF.CompileAsyncQuery((CompanyDbContext context,bool isTracking) =>
             isTracking==true ? context.Set<T>()
              .FirstOrDefault() : context.Set<T>().AsNoTracking()
              .FirstOrDefault());

        private static readonly Func<CompanyDbContext, Expression<Func<T, bool>> ,bool, Task<T>>
          GetFirstByExpressionCompiled = EF.CompileAsyncQuery((CompanyDbContext context, Expression<Func<T, bool>> expression, bool isTrackin) =>
           isTrackin==true ?   context.Set<T>()
              .FirstOrDefault(expression) : context.Set<T>().AsNoTracking()
              .FirstOrDefault(expression));

        private CompanyDbContext _context;

        public void CreateDbContextInstance(DbContext context)
        {
            _context= (CompanyDbContext)context;
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

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, bool IsTracking = true)
        {
            return await GetFirstByExpressionCompiled(_context, expression, IsTracking);
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
