using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Queries.GettAlLCompany
{
    public sealed class GetAllCompanyHandler : IQueryhandler<GetAllCompanyQuery, GetAllCompanyResponse>
    {
        private readonly ICompanyServices _companyServices;

        public GetAllCompanyHandler(ICompanyServices companyServices)
        {
            _companyServices = companyServices;
        }

        public async Task<GetAllCompanyResponse> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
        {

            var result =  _companyServices.GetAllCompanies();

            return new(await result.ToListAsync());
        }
    }
}
