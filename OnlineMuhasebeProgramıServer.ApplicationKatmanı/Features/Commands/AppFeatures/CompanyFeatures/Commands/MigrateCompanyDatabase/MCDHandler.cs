using MediatR;
using OMPS.ApplicationKatmanı.Services.AppServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed class MCDHandler : 
        IRequestHandler<MCDRequest, MCDResponse>
    {
        private readonly ICompanyServices _services;

        public MCDHandler(ICompanyServices services)
        {
            _services = services;
        }

        public async Task<MCDResponse> Handle(MCDRequest request, CancellationToken cancellationToken)
        {

           await _services.MigrateCompanyDatabases();
            return new();
        }
    }
}
