using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using OMPS.InfrastructureKatmani.Authentication;

namespace OMPS.WebApi.Authentication
{
    public sealed class JwrtoptionsSetUp : IConfigureOptions<JwtOptions>
    {
        private const string Jwt = nameof(Jwt);
        private readonly IConfiguration _configuration;

        public JwrtoptionsSetUp(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(JwtOptions options)
        {
         
            _configuration.GetSection(Jwt).Bind(options);
        }
    }
}
