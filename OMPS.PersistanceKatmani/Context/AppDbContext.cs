using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.PersistanceKatmani.Context
{
    public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<AppUserAndCompany> AppUserAndCompanies { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //    base.OnModelCreating(builder);
        //}

    }
}
