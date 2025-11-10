using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.RemoveById
{
    public sealed class RemoveByIdAppUserAndComapnyHandler : ICommandHandler<RemoveByIdAppUserAndComapnyCommand, RemoveByIdAppUserAndComapnyResponse>
    {
        private readonly IAppUserAndCompanyServices _appUserAndCompanyServices;

        public RemoveByIdAppUserAndComapnyHandler(IAppUserAndCompanyServices appUserAndCompanyServices)
        {
            _appUserAndCompanyServices = appUserAndCompanyServices;
        }

        public async Task<RemoveByIdAppUserAndComapnyResponse> Handle(RemoveByIdAppUserAndComapnyCommand request, CancellationToken cancellationToken)
        {
            await _appUserAndCompanyServices.RemoveByIdAsync(request.id);
            return new();
        }
    }
}
