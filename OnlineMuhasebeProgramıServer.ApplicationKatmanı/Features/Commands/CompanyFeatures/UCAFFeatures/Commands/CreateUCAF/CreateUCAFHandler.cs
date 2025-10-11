using MediatR;
using OMPS.ApplicationKatmanı.Services.CompanyServices;

namespace OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFHandler : IRequestHandler<CreateUCAFRequest, CreateUCAFResponse>
    {
        private readonly IUCAFServis _ucafService;

        public CreateUCAFHandler(IUCAFServis ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateUCAFResponse> Handle(CreateUCAFRequest request, CancellationToken cancellationToken)
        {
            await _ucafService.CreateUCAFAsync(request);

            return new();
        }
    }
}
