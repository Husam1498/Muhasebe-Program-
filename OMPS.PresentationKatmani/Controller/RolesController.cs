using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateAllRoles;
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
        public async Task<IActionResult> CreateRole( CreateRoleCommand request)// canceletion tokeni kullanmamızın sebebi role tablosunu Identity clasıından alıyor olması
        {
            CreateRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);

        }
     
        [HttpGet("[action]")]
        public async Task<IActionResult> GettAllRole()
        {
            GetAllRolesQueryt request = new();
            GetAllRoleQueryResponse response = await _mediator.Send(request);
            return Ok(response);

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleCommand request)
        {
            UpdateRoleCommandResponse response = await _mediator.Send(request);

            return Ok(response);

        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteroleCommands request = new(id);
            DeleteRoleCommandResponse response = await _mediator.Send(request);

            return Ok(response);

        }


        [HttpGet("[action]")]
        public async Task<IActionResult> CreateAddRangeRoles()
        {
            CreateAllRolesCommand request = new();
            CreateAllRolesResponse response = await _mediator.Send(request);
            return Ok(response);

        }
    }
}
