using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani;
using OMPS.PersistanceKatmani.Context;

namespace OMPS.PersistanceKatmani
{
    public sealed class UnitOfWorks : IUnitOfWork
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
