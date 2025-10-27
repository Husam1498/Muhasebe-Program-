using OMPS.DomainKatmani.Repository.UCAFRepos;
using OMPS.DomainKatmani.CompanyEnties;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.CompanyDbContext;

namespace OMPS.PersistanceKatmani.Repositories.CompanyDbContext.UCAFRepository
{
    public sealed class UCAFQueryRepository:CompanyDbQueryRepository<UCAF>,IUCAFQueryRepo
    {
    }
}
