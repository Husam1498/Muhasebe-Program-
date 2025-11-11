using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleAndUserRepositories;
using OMPS.DomainKatmani.UnitOfWorks;

namespace OMPS.PersistanceKatmani.Services.AppServices
{
    public sealed class MainRoleAndUserServices : IMainRoleAndUserServices
    {
        private readonly IMainRoleAndUserCommandRepo _commandRepo;
        private readonly IMainRoleAndUserQueryRepo _queryRepo;
        private readonly IAppUnitOfWorks _unitOfWorks;

        public MainRoleAndUserServices(IMainRoleAndUserCommandRepo commandRepo,
            IMainRoleAndUserQueryRepo queryRepo, IAppUnitOfWorks unitOfWorks)
        {
            _commandRepo = commandRepo;
            _queryRepo = queryRepo;
            _unitOfWorks = unitOfWorks;
        }

        public async Task CreateAsync(MainRoleAndUserRelationship role, CancellationToken cancellationToken)
        {
            await _commandRepo.AddAsync(role, cancellationToken);
            await _unitOfWorks.SaveChangesAsync(cancellationToken);
        }

        public async Task<MainRoleAndUserRelationship> GetById(string id)
        {
            return await _queryRepo.GetById(id);
        }

        public async Task<MainRoleAndUserRelationship> GetByUserIdCompanyIdAndRoleIdAsync(
            string userId, string companyId, string mainRoleId,
            CancellationToken cancellationToken = default)
        {
            return await _queryRepo.GetFirstByExpression(
                p => p.UserId == userId && p.CompanyId == companyId && p.MainRoleId == mainRoleId,
                cancellationToken
                );
        }

        public async Task RemoveByIdAsync(string id)
        {
            await _commandRepo.RemoveById(id);
            await _unitOfWorks.SaveChangesAsync();
        }
    }
}
