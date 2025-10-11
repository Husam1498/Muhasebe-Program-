#region Usings
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.OpenApi.Models;
    using OMPS.ApplicationKatmaný.Services.AppServices;
using OMPS.DomainKatmani;
using OMPS.DomainKatmani.AppEntities.Identity;
using OMPS.PersistanceKatmani;
using OMPS.PersistanceKatmani.Context;
    using OMPS.PersistanceKatmani.Services.AppServices;
#endregion


namespace OMPS.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region COntrollers added
            builder.Services.AddControllers()
                .AddApplicationPart(typeof(OMPS.PresentationKatmani.AssemblyReferance).Assembly);// presentation katmanýndaki controllerlarý tanýtmak için
            #endregion

            #region Db COntext and identity services added
            builder.Services.AddDbContext<AppDbContext>(opts=>
            {
                opts.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));

            });
                // ýdentity tanýmlama
                builder.Services.AddIdentity<AppUser,AppRole>()
                .AddEntityFrameworkStores<AppDbContext>();
            #endregion

            #region Servisler tanýmý

            builder.Services.AddScoped<ICompanyServices,CompanyServices>();
            builder.Services.AddScoped<IUnitOfWork,UnitOfWorks>();
            #endregion

            #region mediatR services added
      
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(OMPS.ApplicationKatmaný.AssemblyReferance).Assembly));
            // builder.Services.AddMediatR(typeof(OMPS.ApplicationKatmaný.AssemblyReferance).Assembly));
            #endregion

            #region AutoMapper services added
            // builder.Services.AddAutoMapper(typeof(OMPS.PresentationKatmani.AssemblyReferance).Assembly);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            #endregion

            #region Swager added
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(setup =>
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

            var app = builder.Build();

            //Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

