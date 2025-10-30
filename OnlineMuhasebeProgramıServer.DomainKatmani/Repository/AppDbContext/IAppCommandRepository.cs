using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.Repository.GenericRepository;

namespace OMPS.DomainKatmani.Repository.AppDbContext
{
    public  interface IAppCommandRepository<T>:ICommandGenericRepository<T> where T : Entity
    {
        public DbSet<T> Entity {  get; set; }

    }
}
