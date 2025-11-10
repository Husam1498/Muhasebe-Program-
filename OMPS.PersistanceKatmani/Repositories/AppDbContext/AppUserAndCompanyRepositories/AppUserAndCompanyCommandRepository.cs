using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.AppUserAndCompanyRepositories;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.AppUserAndCompanyRepositories
{
    public sealed class AppUserAndCompanyCommandRepository : AppCommandRepository<AppUserAndCompany>, 
        IAppUserAndCompanyCommandRepo
    {
        public AppUserAndCompanyCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
