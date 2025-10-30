using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleRepositories;
using OMPS.DomainKatmani.UnitOfWorks;
using System.Threading;

namespace OMPS.PersistanceKatmani.Services.AppServices
{
    public class MainRoleService : IMainRoleService
    {
        private readonly IMainRoleCommandRepo _commandRepo;
        private readonly IMainRoleQueryRepo _queryRepo;
        private readonly IAppUnitOfWorks _unitOfWorks;

        public MainRoleService(IMainRoleQueryRepo queryRepo, IMainRoleCommandRepo commandRepo, IAppUnitOfWorks unitOfWorks)
        {
            _queryRepo = queryRepo;
            _commandRepo = commandRepo;
            _unitOfWorks = unitOfWorks;
        }

        public async Task CreateAsync(MainRole role , CancellationToken cancellationToken)
        {
            await _commandRepo.AddAsync(role, cancellationToken);
            await _unitOfWorks.SaveChangesAsync(cancellationToken);
        }

        public async Task CreateRangeAsync(List<MainRole> mainRoles, CancellationToken cancellationToken)
        {
            await _commandRepo.AddRangeAsync(mainRoles, cancellationToken);
            await _unitOfWorks.SaveChangesAsync(cancellationToken);

        }

        public IQueryable<MainRole> GetAll()
        {
            return _queryRepo.GetAll();
        }

        public async Task<MainRole> GetByTitleAndCompanyId(string Title, string CompanyId , CancellationToken cancellationToken)
        {
            //if(CompanyId == null) return await _queryRepo.GetFirstByExpression(p => p.Title == Title);

            return await _queryRepo.GetFirstByExpression(p => p.Title == Title && 
                p.CompanyId == CompanyId, cancellationToken,false);
        }
    }
}
