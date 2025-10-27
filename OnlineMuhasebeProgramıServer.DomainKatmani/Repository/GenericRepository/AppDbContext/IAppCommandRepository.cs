using Microsoft.EntityFrameworkCore;
using OMPS.DomainKatmani.Abstractions;

namespace OMPS.DomainKatmani.Repository.GenericRepository.AppDbContext
{
    public  interface IAppCommandRepository<T>:ICommandGenericRepository<T> where T : Entity
    {
        public DbSet<T> Entity {  get; set; }

    }
}
