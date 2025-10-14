using OMPS.WebApi.Configuration;
using OMPS.WebApi.Midleware;

namespace OMPS.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Add services to the container.
            builder.Services
                .InstallService(builder.Configuration, typeof(IServisInstaller).Assembly);
            #endregion

            var app = builder.Build();

            //Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }

            app.UseExceptionMidleware();

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

