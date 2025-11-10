using OMPS.DomainKatmani.AppEntities;
using OMPS.DomainKatmani.Repository.AppDbContext.MainRoleAndUserRepositories;
using OMPS.PersistanceKatmani.Repositories.GenericRepository.AppDbContextRepository;

namespace OMPS.PersistanceKatmani.Repositories.AppDbContext.MainRoleAndUser
{
    public sealed class MainRoleAndUserCommandRepository : AppCommandRepository<MainRoleAndUserRelationship>, IMainRoleAndUserCommandRepo
    {        
        public MainRoleAndUserCommandRepository(Context.AppDbContext context) : base(context)
        {
     
        }


    }
}
