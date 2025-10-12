using System.Reflection;

namespace OMPS.WebApi.Configuration
{
    public static class DependencyInjektion
    {
        public static IServiceCollection InstallService(
            this IServiceCollection services,
            IConfiguration configuration,
            params Assembly[] assemblies)
        {
           IEnumerable<IServisInstaller> installers = assemblies.SelectMany(a => a.DefinedTypes)
                .Where(IsAssignableToType<IServisInstaller>)
                .Select(Activator.CreateInstance)
                .Cast<IServisInstaller>();

            foreach (IServisInstaller serviceInstaller in installers)
            {
                serviceInstaller.InstallServices(services, configuration);
            }

            return services;

            static bool IsAssignableToType<T>(TypeInfo typeInfo)=>
               typeof(T).IsAssignableFrom(typeInfo)
                && !typeInfo.IsInterface
                && !typeInfo.IsAbstract;

          
        }

    }
}
