using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Services.AppServices
{
    public interface  IAppUserAndCompanyServices 
    {
        Task CreateAsync(AppUserAndCompany role, CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);
        Task<AppUserAndCompany> GetByIdAsync(string id);
        Task<AppUserAndCompany> GetByUserIdAndCompanyId(string userId, string companyId,
            CancellationToken cancellationToken = default);

        //Task UpdateAsync(AppUserAndCompany role);
        //IQueryable<AppUserAndCompany> GetAll();  

    }
}
