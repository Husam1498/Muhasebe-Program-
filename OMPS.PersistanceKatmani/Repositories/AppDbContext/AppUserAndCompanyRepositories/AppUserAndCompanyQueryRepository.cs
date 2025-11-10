using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.AppUserAndCompanyRepositories;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.AppUserAndCompanyRepositories
{
    public sealed class AppUserAndCompanyQueryRepository : AppQueryRepository<AppUserAndCompany>, IAppUserAndCompanyQueryRepo
    {
        public AppUserAndCompanyQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
