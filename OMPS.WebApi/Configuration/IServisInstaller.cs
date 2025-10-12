namespace OMPS.WebApi.Configuration
{
    public interface IServisInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);

    }
}
