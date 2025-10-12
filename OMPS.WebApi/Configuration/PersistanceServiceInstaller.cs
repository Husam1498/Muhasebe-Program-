
using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.AppEntities.Identity;
using OMPS.PersistanceKatmani.Context;

namespace OMPS.WebApi.Configuration
{
    public class PersistanceServiceInstaller : IServisInstaller
    {
        private const string SectionName = "SqlServer";
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {

            #region Db COntext and identity services added
            services.AddDbContext<AppDbContext>(opts =>
            {
                opts.UseSqlServer(configuration.GetConnectionString(SectionName));

            });
            // ıdentity tanımlama
            services.AddIdentity<AppUser, AppRole>()
            .AddEntityFrameworkStores<AppDbContext>();
            #endregion

            #region AutoMapper services added
            // builder.Services.AddAutoMapper(typeof(OMPS.PresentationKatmani.AssemblyReferance).Assembly);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            #endregion
        }
    }
}
