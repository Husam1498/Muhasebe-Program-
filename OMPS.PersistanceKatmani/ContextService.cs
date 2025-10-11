using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani;
using OMPS.DomainKatmani.AppEntities;
using OMPS.PersistanceKatmani.Context;

namespace OMPS.PersistanceKatmani
{
    public sealed class ContextService : IContextService
    {
        private AppDbContext _appDbContext;

        public ContextService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public DbContext CreateDbContextInstance(string companyId)
        {
            Company company = _appDbContext.Companies.Find( companyId);

            return new CompanyDbContext(company);
        }
    }
}
