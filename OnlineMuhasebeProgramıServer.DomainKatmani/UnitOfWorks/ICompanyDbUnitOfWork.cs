using Microsoft.EntityFrameworkCore;

namespace OMPS.DomainKatmani.UnitOfWorks
{
    public interface ICompanyDbUnitOfWork : IUnitOfWorks
    {
        void CreateDbContextInstance(DbContext context);
    }
}
