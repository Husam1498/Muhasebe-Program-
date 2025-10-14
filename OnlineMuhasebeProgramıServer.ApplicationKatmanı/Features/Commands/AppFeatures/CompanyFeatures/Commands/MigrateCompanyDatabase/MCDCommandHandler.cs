using MediatR;
using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.AppServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed class MCDCommandHandler : 
        ICommandHandler<MCDCommand, MCDCommandResponse>
    {
        private readonly ICompanyServices _services;

        public MCDCommandHandler(ICompanyServices services)
        {
            _services = services;
        }

        public async Task<MCDCommandResponse> Handle(MCDCommand request, CancellationToken cancellationToken)
        {

           await _services.MigrateCompanyDatabases();
            return new();
        }
    }
}
