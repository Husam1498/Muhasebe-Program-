using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.CompanyServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFCommandHandler : ICommandHandler<CreateUCAFCommand, CreateUCAFCommandResponse>
    {
        private readonly IUCAFServis _ucafService;

        public CreateUCAFCommandHandler(IUCAFServis ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateUCAFCommandResponse> Handle(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            await _ucafService.CreateUCAFAsync(request, cancellationToken);

            return new();
        }
    }
}
