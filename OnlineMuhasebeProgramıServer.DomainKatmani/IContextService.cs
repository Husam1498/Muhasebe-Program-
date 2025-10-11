using Microsoft.EntityFrameworkCore;

namespace OMPS.DomainKatmani
{
    public interface  IContextService
    {
        DbContext CreateDbContextInstance(string companyId);
    }
}
