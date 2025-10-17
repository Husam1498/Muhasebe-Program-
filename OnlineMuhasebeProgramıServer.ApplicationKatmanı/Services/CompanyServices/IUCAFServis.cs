using OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OMPS.DomainKatmani.CompanyEnties;

namespace OMPS.ApplicationKatmanı.Services.CompanyServices
{
    public interface IUCAFServis
    {
        Task CreateUCAFAsync(CreateUCAFCommand request, CancellationToken cancellationToken);
        Task<UCAF> GetByCode( string code);
    }
}
