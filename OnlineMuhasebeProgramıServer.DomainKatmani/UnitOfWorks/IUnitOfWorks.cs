namespace OMPS.DomainKatmani.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}
