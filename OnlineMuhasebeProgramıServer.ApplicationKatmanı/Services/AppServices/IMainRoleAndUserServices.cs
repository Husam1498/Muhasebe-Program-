using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Services.AppServices
{
    public interface IMainRoleAndUserServices
    {
        Task CreateAsync(MainRoleAndUserRelationship role, CancellationToken cancellationToken);

        Task UpdateAsync(MainRoleAndUserRelationship role);

        Task RemoveByIdAsync(string id);

        IQueryable<MainRoleAndUserRelationship> GetAll();

        Task<MainRoleAndUserRelationship> GetByIdAsync(string id);
        Task<MainRoleAndUserRelationship> GetByRoleIdAndMainRoleId(string roleId, string mainRoleId,
            CancellationToken cancellationToken = default);
    }
}
