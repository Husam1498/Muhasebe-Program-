using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.PersistanceKatmani.Services.AppServices
{
    public sealed class MainRoleAndUserServices : IMainRoleAndUserServices
    {
        public Task CreateAsync(MainRoleAndUserRelationship role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public IQueryable<MainRoleAndUserRelationship> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<MainRoleAndUserRelationship> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<MainRoleAndUserRelationship> GetByRoleIdAndMainRoleId(string roleId, string mainRoleId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task RemoveByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MainRoleAndUserRelationship role)
        {
            throw new NotImplementedException();
        }
    }
}
