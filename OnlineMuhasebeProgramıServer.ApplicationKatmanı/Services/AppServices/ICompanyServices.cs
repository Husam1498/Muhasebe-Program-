using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Services.AppServices
{
    public  interface ICompanyServices
    {
        Task CreateCompanyAsync(CreateCompayRequest request);
        Task MigrateCompanyDatabases();
        Task<Company?> GetCompanyByName(string name);
    }
}
