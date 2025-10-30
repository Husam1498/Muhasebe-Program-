using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyCommandHandler : 
        ICommandHandler<CreateCompayCommand, CreateCompanyCommandResponse>
    {
        private readonly ICompanyServices _companyServices;
        public CreateCompanyCommandHandler(ICompanyServices companyServices)
        {
            _companyServices = companyServices;
        }
        public async Task<CreateCompanyCommandResponse> Handle(CreateCompayCommand request, 
            CancellationToken cancellationToken)
        {
            Company company= await _companyServices.GetCompanyByName(request.Name,cancellationToken);
            if (company!= null)
                throw new Exception("Aynı isimde şirket zaten mevcut");
            await _companyServices.CreateCompanyAsync(request,cancellationToken);
            return new();
        }
    }
}
