using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;

namespace OMPS.DomainKatmani.Repository.GenericRepository.AppDbContext
{
    public interface IAppQueryRepository<T>:IQueryGenericRepository<T> where T : Entity
    {
        public DbSet<T> Entity { get; set; }
    }
}
