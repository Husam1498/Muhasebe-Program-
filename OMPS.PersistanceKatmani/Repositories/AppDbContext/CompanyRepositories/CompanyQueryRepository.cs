using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.GenericRepository.AppDbContext.CompanyRepositories;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.CompanyRepositories
{
    public sealed class CompanyQueryRepository : AppQueryRepository<Company>,ICompanyQueryRepository
    {
        public CompanyQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
