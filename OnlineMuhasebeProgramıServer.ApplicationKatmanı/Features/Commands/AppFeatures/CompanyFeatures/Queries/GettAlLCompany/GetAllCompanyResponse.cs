using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Queries.GettAlLCompany
{
    public sealed record GetAllCompanyResponse(IList<Company> Companies);

}
