
using OMPS.ApplicationKatmanı.Abstract;
using OMPS.InfrastructureKatmani.Authentication;

namespace OMPS.WebApi.Configuration
{
    public class InfraastructorDIInstallerService : IServisInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
           services.AddScoped<IJwtProvider, JwtProvider>();
        }
    }
}
