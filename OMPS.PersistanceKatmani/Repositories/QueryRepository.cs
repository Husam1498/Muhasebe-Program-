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
        private static readonly Func<CompanyDbContext, string, Task<T>>
            GetbyIdCompiled = EF.CompileAsyncQuery((CompanyDbContext context, string id) =>
                context.Set<T>()
                .FirstOrDefault(p => p.Id == id));

        private static readonly Func<CompanyDbContext, Task<T>>
          GetbyFirstCompiled = EF.CompileAsyncQuery((CompanyDbContext context) =>
              context.Set<T>()
              .FirstOrDefault());

        private static readonly Func<CompanyDbContext, Expression<Func<T, bool>> , Task<T>>
          GetFirstByExpressionCompiled = EF.CompileAsyncQuery((CompanyDbContext context, Expression<Func<T, bool>> expression) =>
              context.Set<T>()
              .FirstOrDefault(expression));

        private CompanyDbContext _context;

        public void CreateDbContextInstance(DbContext context)
        {
            _context= (CompanyDbContext)context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public async Task<T> GetById(string Id)
        {
            return await GetbyIdCompiled(_context, Id);
        }

        public async Task<T> GetFirst()
        {
            return await GetbyFirstCompiled(_context);
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression)
        {
            return await GetFirstByExpressionCompiled(_context, expression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

   
    }
}
