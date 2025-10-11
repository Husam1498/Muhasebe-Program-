
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OMPS.DomainKatmani.AppEntities;


//TÜm şirketlerin kendilerine ait şirketle riçin veri tabanı oluşturması
//ve bu veri tabanlarının yönetilmesi için kullanılacak DbContext sınıfı.


namespace OMPS.PersistanceKatmani.Context
{
    public sealed class CompanyDbContext:DbContext
    {

        private string ConnectionString = "";
        private readonly AppDbContext _appDbContext;

        public CompanyDbContext( Company company=null)
        {
            if (company != null)
            {
                if (company.UserId == "")
                {
                    ConnectionString = $"Data Source={company.ServerName};" +
                            $" Initial Catalog=  {company.DatabaseName};" +
                            $"Integrated Security=True;" +
                            $"Connect Timeout=30;Encrypt=True;" +
                            $"Trust Server Certificate=True;" +
                            $"Application Intent=ReadWrite;" +
                            $"Multi Subnet Failover=False";
                }
                else
                {
                    ConnectionString = $"Data Source={company.ServerName};" +
                        $" Initial Catalog=  {company.DatabaseName}; " +
                        $"UserId={company.UserId}; " +
                        $"Password={company.Password} " +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;Encrypt=True;" +
                        $"Trust Server Certificate=True;" +
                        $"Application Intent=ReadWrite;" +
                        $"Multi Subnet Failover=False";
                }
            }
        

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReferance).Assembly);
        }

        public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {
      
            public CompanyDbContext CreateDbContext(string[] args)
            {
            
                return new CompanyDbContext();
            }
        }


    }


}
