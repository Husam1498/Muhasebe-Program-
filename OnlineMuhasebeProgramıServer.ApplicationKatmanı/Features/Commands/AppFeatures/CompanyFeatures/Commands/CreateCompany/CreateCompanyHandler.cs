using MediatR;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

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
            Company company= await _companyServices.GetCompanyByName(request.Name);
            if (company!= null)
                throw new Exception("Aynı isimde şirket zaten mevcut");
            await _companyServices.CreateCompanyAsync(request);
            return new();
        }
    }
}
