using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Services.AppServices
{
    public interface IMainRoleAndRoleRelationshipServices
    {
        Task CreateAsync(MainRoleAndRoleRelationship role, CancellationToken cancellationToken);

        Task UpdateAsync(MainRoleAndRoleRelationship role);

        Task RemoveByIdAsync(string id);

        IQueryable<MainRoleAndRoleRelationship> GetAll();

        Task<MainRoleAndRoleRelationship> GetByIdAsync(string id);
        Task<MainRoleAndRoleRelationship> GetByRoleIdAndMainRoleId(string roleId, string mainRoleId,
            CancellationToken cancellationToken=default);

    }
}
