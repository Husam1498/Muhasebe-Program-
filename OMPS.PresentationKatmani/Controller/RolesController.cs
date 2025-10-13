using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.DeleteRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.UpdateRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Queries;
using OMPS.PresentationKatmani.Abstraction;

namespace OMPS.PresentationKatmani.Controller
{
    public sealed class RolesController : ApiController
    {
        public RolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateRole( CreateRoleRequest request)
        {
            CreateRoleResponse response = await _mediator.Send(request);
            return Ok(response);

        }
     
        [HttpGet("[action]")]
        public async Task<IActionResult> GettAllRole()
        {
            GetAllRolesRequest request = new();
            GetAllRoleResponse response = await _mediator.Send(request);
            return Ok(response);

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleRequest request)
        {
            UpdateRoleResponse response = await _mediator.Send(request);

            return Ok(response);

        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteroleCommands request = new() { Id = id };
            DeleteRoleResponse response = await _mediator.Send(request);

            return Ok(response);

        }
    }
}
