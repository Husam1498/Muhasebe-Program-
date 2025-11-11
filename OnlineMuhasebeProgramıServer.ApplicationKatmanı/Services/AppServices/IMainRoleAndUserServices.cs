using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Services.AppServices
{
    public interface IMainRoleAndUserServices
    {
        Task CreateAsync(MainRoleAndUserRelationship role, CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);
        Task<MainRoleAndUserRelationship> GetByUserIdCompanyIdAndRoleIdAsync(
            string userId, string companyId, string mainRoleId,
            CancellationToken cancellationToken = default);
        Task<MainRoleAndUserRelationship> GetById(string id);
    }
}
