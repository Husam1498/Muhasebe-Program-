using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.CreateAppUserAndComapny
{
    public sealed class CreateAppUserAndComapnyHandler : ICommandHandler<CreateAppUserAndComapnyCommand, CreateAppUserAndComapnyResponse>
    {
        private readonly IAppUserAndCompanyServices _appUserAndCompanyServices;

        public CreateAppUserAndComapnyHandler(IAppUserAndCompanyServices appUserAndCompanyServices)
        {
            _appUserAndCompanyServices = appUserAndCompanyServices;
        }

        public async Task<CreateAppUserAndComapnyResponse> Handle(CreateAppUserAndComapnyCommand request, CancellationToken cancellationToken)
        {

           AppUserAndCompany entity = await _appUserAndCompanyServices.GetByUserIdAndCompanyId(
               request.userId,request.companyId);
            if (entity != null) throw new Exception("Bu ilişki daha önce mevcuttur");

            AppUserAndCompany appUserAndCompany =new AppUserAndCompany
            {
                Id=Guid.NewGuid().ToString(),
                UserId=request.userId,
                CompanyId=request.companyId,
            };
            await _appUserAndCompanyServices.CreateAsync(appUserAndCompany, cancellationToken);

            return new();
            
        }
    }
}
