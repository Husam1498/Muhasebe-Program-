using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.AppUserAndCompanyRepositories;
using OMPS.DomainKatmani.UnitOfWorks;

namespace OMPS.PersistanceKatmani.Services.AppServices
{
    public sealed class AppUserAndCompanyServices : IAppUserAndCompanyServices
    {
        private readonly IAppUserAndCompanyCommandRepo _commandRepo;
        private readonly IAppUserAndCompanyQueryRepo _queryRepo;
        private readonly IAppUnitOfWorks  _unitOfWorks;

        public AppUserAndCompanyServices(IAppUserAndCompanyCommandRepo commandRepo, 
            IAppUserAndCompanyQueryRepo queryRepo, IAppUnitOfWorks unitOfWorks)
        {
            _commandRepo = commandRepo;
            _queryRepo = queryRepo;
            _unitOfWorks = unitOfWorks;
        }

        public async Task CreateAsync(AppUserAndCompany role, CancellationToken cancellationToken)
        {
            await _commandRepo.AddAsync(role, cancellationToken);
            await _unitOfWorks.SaveChangesAsync(cancellationToken);
        }

        public async Task<AppUserAndCompany> GetByIdAsync(string id)
        {
           return await _queryRepo.GetById(id);
        }

        public async Task<AppUserAndCompany> GetByUserIdAndCompanyId(string userId,
            string companyId, CancellationToken cancellationToken = default)
        {
            return await _queryRepo.GetFirstByExpression(p => p.UserId == userId &&
                p.CompanyId == companyId, cancellationToken);
        }

        public async Task RemoveByIdAsync(string id)
        {
           await _commandRepo.RemoveById(id);
            await _unitOfWorks.SaveChangesAsync();
        }
    }
}
