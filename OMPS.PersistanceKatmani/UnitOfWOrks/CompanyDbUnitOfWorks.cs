using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.UnitOfWorks;
using OMPS.PersistanceKatmani.Context;

namespace OMPS.PersistanceKatmani.UnitOfWOrks
{
    public sealed class CompanyDbUnitOfWorks : ICompanyDbUnitOfWork
    {
        private CompanyDbContext _context;
        public void CreateDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
        }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            int count= await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
