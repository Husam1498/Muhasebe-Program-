using OMPS.ApplicationKatmanı.Messaging;
using OMPS.ApplicationKatmanı.Services.CompanyServices;
using OMPS.DomainKatmani.CompanyEnties;

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
            UCAF ucaf= await _ucafService.GetByCode(request.Code);
            if (ucaf != null) throw new Exception("Bu hesap planı Kodu daha önce açılmış");

            await _ucafService.CreateUCAFAsync(request, cancellationToken);

            return new();
        }
    }
}
