using Microsoft.EntityFrameworkCore;

namespace OMPS.DomainKatmani
{
    public interface IUnitOfWork
    {
        void CreateDbContextInstance(DbContext context);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
