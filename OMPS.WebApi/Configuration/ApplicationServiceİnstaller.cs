using FluentValidation;
using MediatR;
using OMPS.ApplicationKatmanı;
using OMPS.ApplicationKatmanı.Behavior;

namespace OMPS.WebApi.Configuration
{
    public class ApplicationServiceİnstaller : IServisInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            #region mediatR services added

           services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(OMPS.ApplicationKatmanı.AssemblyReferance).Assembly));
            // builder.Services.AddMediatR(typeof(OMPS.ApplicationKatmanı.AssemblyReferance).Assembly));
            #endregion

            #region FluentValidation services added

            services.AddTransient(typeof(IPipelineBehavior<,>),
                typeof(ValidationBehavior<,>));

            services.AddValidatorsFromAssembly(typeof(AssemblyReferance).Assembly);
            #endregion

        }
    }
}
