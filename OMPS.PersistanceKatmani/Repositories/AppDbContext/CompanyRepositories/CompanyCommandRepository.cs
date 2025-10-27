using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.GenericRepository.AppDbContext.CompanyRepositories;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.CompanyRepositories
{
    public sealed class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
