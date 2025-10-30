using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository.GenericRepository;

namespace OMPS.DomainKatmani.Repository.AppDbContext
{
    public interface IAppQueryRepository<T>:IQueryGenericRepository<T> where T : Entity
    {
        public DbSet<T> Entity { get; set; }
    }
}
