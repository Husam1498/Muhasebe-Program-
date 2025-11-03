using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.ApplicationKatmanı.Services.CompanyServices;
using OMPS.DomainKatmani;
using OMPS.DomainKatmani.Repository.AppDbContext.CompanyRepositories;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleAndRoleRepositories;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleRepositories;
using OMPS.DomainKatmani.Repository.UCAFRepos;
using OMPS.DomainKatmani.UnitOfWorks;
using OMPS.PersistanceKatmani;
using OMPS.PersistanceKatmani.Repositories.AppDbContext.CompanyRepositories;
using OMPS.PersistanceKatmani.Repositories.AppDbContext.MainRoleAndRole;
using OMPS.PersistanceKatmani.Repositories.AppDbContext.MainRoleRepositories;
using OMPS.PersistanceKatmani.Repositories.CompanyDbContext.UCAFRepository;
using OMPS.PersistanceKatmani.Services.AppServices;
using OMPS.PersistanceKatmani.Services.CompanyServices;
using OMPS.PersistanceKatmani.UnitOfWOrks;

namespace OMPS.WebApi.Configuration
{
    public class PersistandeDIServicesInstaller : IServisInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            #region Servisler tanımı

                #region UnıtOfWork and ContextService
                    services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWorks>();
                    services.AddScoped<IContextService, ContextService>();
                    services.AddScoped<IAppUnitOfWorks, AppUnitOfWorks>();
                    //services.AddScoped<IUnitOfWorks, Unito>();
                    
            #endregion

                #region Service Layer Services
                     services.AddScoped<IUCAFServis, UCAFService>();
                     services.AddScoped<ICompanyServices, CompanyServices>();
                     services.AddScoped<IRolesService, RoleService>();
                     services.AddScoped<IMainRoleService , MainRoleService>();
                     services.AddScoped<IMainRoleAndRoleRelationshipServices , MainRoleAndRoleServices>();
                     
            #endregion

                #region Repositories
                    services.AddScoped<IUCAFCommandRepo, UCAFCommandRepository>();
                    services.AddScoped<IUCAFQueryRepo, UCAFQueryRepository>();

                    services.AddScoped<ICompanyCommandRepository,CompanyCommandRepository>();
                    services.AddScoped<ICompanyQueryRepository,CompanyQueryRepository>();

                    services.AddScoped<IMainRoleCommandRepo, MainRoleCommandRepository>();
                    services.AddScoped<IMainRoleQueryRepo, MainRoleQueryRepository>();

                    services.AddScoped<IMainRoleAndRoleCommandRepo, MainRoleAndRoleCommandRepository>();
                    services.AddScoped<IMainRoleAndRoleQueryRepo, MainRoleAndRoleQueryRepository>();
            #endregion

            #endregion
        }
    }
}
