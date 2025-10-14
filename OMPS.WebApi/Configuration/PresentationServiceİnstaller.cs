
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using OMPS.WebApi.Midleware;

namespace OMPS.WebApi.Configuration
{
    public class PresentationServiceİnstaller : IServisInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ExceptionMidleware>();// midleware ı service olarak ekledik

            #region COntrollers added
            services.AddControllers()
                .AddApplicationPart(typeof(OMPS.PresentationKatmani.AssemblyReferance).Assembly);// presentation katmanındaki controllerları tanıtmak için
            #endregion

            #region Swager added
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(setup =>
            {
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

                setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { jwtSecurityScheme, Array.Empty<string>() }
                });
            });
            #endregion
        }
    }
}
