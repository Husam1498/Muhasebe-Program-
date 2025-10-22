using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.PersistanceKatmani.Services.AppServices
{
    public sealed class RoleService : IRolesService
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IMapper _mapper;

        public RoleService(RoleManager<AppRole> roleManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateRoleCommand request)
        {
            AppRole role = _mapper.Map<AppRole>(request);
            role.Id = Guid.NewGuid().ToString();
            await _roleManager.CreateAsync(role);
        }

        public async Task AddRange(IEnumerable<AppRole> Roles)
        {
          foreach(var role in Roles)
            {
               await _roleManager.CreateAsync(role);
            }
        }

        public async Task DeleteAsync(AppRole appRole)
        {  
            await _roleManager.DeleteAsync(appRole);
        }

        public Task<IList<AppRole>> GetAllRolesAsync()
        {
            IList<AppRole> roles = _roleManager.Roles.ToList();
            return Task.FromResult(roles);
        }

        public async Task<AppRole> GetByCode(string id)
        {
            AppRole role = await _roleManager.Roles.FirstOrDefaultAsync(r=> r.Code==id) ;
            return role;
        }

        public async Task<AppRole> GetById(string id)
        {
            AppRole role = await _roleManager.FindByIdAsync(id);
            return role;
        }

        public async Task UpdateAsync(AppRole appRole)
        {
           await _roleManager.UpdateAsync(appRole);
        }

    }
}
