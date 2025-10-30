using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Services.AppServices
{
    public interface IMainRoleService
    {   
        Task<MainRole> GetByTitleAndCompanyId(string Title, string CompanyId, CancellationToken cancellationToken);
        Task<MainRole> GetById(string id);
        Task RemoveByIdAsync(string Id);
        Task CreateAsync(MainRole role,CancellationToken cancellationToken);
        Task CreateRangeAsync(List<MainRole> roles,CancellationToken cancellationToken);
        IQueryable<MainRole> GetAll();

        Task UpdateAsync(MainRole mainRole);

    }
}
