using MediatR;
using OMPS.ApplicationKatmanı.Services.AppServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyHandler : 
        IRequestHandler<CreateCompayRequest, CreateCompanyResponse>
    {
        private readonly ICompanyServices _companyServices;
        public CreateCompanyHandler(ICompanyServices companyServices)
        {
            _companyServices = companyServices;
        }
        public async Task<CreateCompanyResponse> Handle(CreateCompayRequest request, 
            CancellationToken cancellationToken)
        {

            await _companyServices.CreateCompanyAsync(request);
            return new();
        }
    }
}
