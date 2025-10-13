using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Queries
{
    public sealed class GettAllRoleshandler : IRequestHandler<GetAllRolesRequest, GetAllRoleResponse>
    {
        private readonly IRolesService _rolesService;

        public GettAllRoleshandler(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        public async Task<GetAllRoleResponse> Handle(GetAllRolesRequest request, CancellationToken cancellationToken)
        {
           IList<AppRole> roles=await _rolesService.GetAllRolesAsync();

            return  new GetAllRoleResponse { Roles = roles };
        }
    }
}
