
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.ApplicationKatmanı.Services.CompanyServices;
using OMPS.DomainKatmani;
using OMPS.DomainKatmani.Repository.UCAFRepos;
using OMPS.PersistanceKatmani;
using OMPS.PersistanceKatmani.Repositories.UCAFRepository;
using OMPS.PersistanceKatmani.Services.AppServices;
using OMPS.PersistanceKatmani.Services.CompanyServices;

namespace OMPS.WebApi.Configuration
{
    public class PersistandeDIServicesInstaller : IServisInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            #region Servisler tanımı

                #region UnıtOfWork and ContextService
                    services.AddScoped<IUnitOfWork, UnitOfWorks>();
                    services.AddScoped<IContextService, ContextService>();
            #endregion

                #region Service Layer Services
                     services.AddScoped<IUCAFServis, UCAFService>();
                     services.AddScoped<ICompanyServices, CompanyServices>();
            #endregion

                 #region Repositories
                    services.AddScoped<IUCAFCommandRepo, UCAFCommandRepository>();
                    services.AddScoped<IUCAFQueryRepo, UCAFQueryRepository>();
                #endregion

            #endregion
        }
    }
}
