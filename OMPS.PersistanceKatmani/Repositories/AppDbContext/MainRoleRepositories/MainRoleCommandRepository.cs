using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleRepositories;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;


namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.MainRoleRepositories
{
    public sealed class MainRoleCommandRepository : AppCommandRepository<MainRole>, IMainRoleCommandRepo
    {
        public MainRoleCommandRepository(Context.AppDbContext context) : base(context) {}
    }
}
