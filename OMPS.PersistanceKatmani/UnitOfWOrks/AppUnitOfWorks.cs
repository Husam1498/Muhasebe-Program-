using OMPS.DomainKatmani.UnitOfWorks;
using OMPS.PersistanceKatmani.Context;

namespace OMPS.PersistanceKatmani.UnitOfWOrks
{
    public sealed class AppUnitOfWorks : IAppUnitOfWorks
    {
        private readonly AppDbContext _appDbContext;

        public AppUnitOfWorks(AppDbContext appDbContext)
        {
          _appDbContext = appDbContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
           int count= await _appDbContext.SaveChangesAsync(cancellationToken);
           return count;
        }
    }
}
