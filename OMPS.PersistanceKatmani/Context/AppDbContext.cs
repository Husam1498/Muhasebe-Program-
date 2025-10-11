using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OMPS.DomainKatmani.Abstractions;
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
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           var entires= ChangeTracker.Entries<Entity>();

            foreach (var entry in entires)
            {
                if (entry.State == EntityState.Added)
                {                   
                    entry.Property(e => e.CreatedDate)
                       .CurrentValue = DateTime.Now;
                }
                if(entry.State == EntityState.Modified)
                {
                    entry.Property(e => e.UpdatedDate)
                     .CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {

            public AppDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder();
                var connectionString = "Data Source=DESKTOP-S32BE3K; Initial Catalog= MuhasebeProgramiAnaDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
                optionsBuilder.UseSqlServer(connectionString);

                return new AppDbContext(optionsBuilder.Options);
            }
        }
    }
}
