using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleAndRoleRepositories;
using OMPS.DomainKatmani.UnitOfWorks;

namespace OMPS.PersistanceKatmani.Services.AppServices
{
    public class MainRoleAndRoleServices : IMainRoleAndRoleRelationshipServices
    {

        private readonly IMainRoleAndRoleCommandRepo _commandRepo;
        private readonly IMainRoleAndRoleQueryRepo _queryRepo;
        private readonly IAppUnitOfWorks _unityOfWorks;

        public MainRoleAndRoleServices(IMainRoleAndRoleCommandRepo commandRepo,
            IMainRoleAndRoleQueryRepo queryRepo,
            IAppUnitOfWorks unityOfWorks)
        {
            _commandRepo = commandRepo;
            _queryRepo = queryRepo;
            _unityOfWorks = unityOfWorks;
        }

        public async Task CreateAsync(MainRoleAndRoleRelationship role,
            CancellationToken cancellationToken)
        {
            await _commandRepo.AddAsync(role, cancellationToken);
            await _unityOfWorks.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<MainRoleAndRoleRelationship> GetAll()
        {
            return _queryRepo.GetAll();
        }

        public async Task<MainRoleAndRoleRelationship> GetByIdAsync(string id)
        {
            return await _queryRepo.GetById(id);
        }

        public async Task<MainRoleAndRoleRelationship> GetByRoleIdAndMainRoleId(string roleId,
            string mainRoleId, CancellationToken cancellationToken=default)
        {
            return await _queryRepo
                .GetFirstByExpression(p => p.RoleId == roleId
                && p.MainRoleId == mainRoleId, cancellationToken);
        }

        public async Task RemoveByIdAsync(string id)
        {
            await _commandRepo.RemoveById(id);
            await _unityOfWorks.SaveChangesAsync();
        }

        public async Task UpdateAsync(MainRoleAndRoleRelationship role)
        {
            _commandRepo.Update(role);
            await _unityOfWorks.SaveChangesAsync();
        }
    }
}
