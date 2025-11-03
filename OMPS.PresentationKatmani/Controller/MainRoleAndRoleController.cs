using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands.Create;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands.RemoveById;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Queries.GetAllMainRoleAndRole;
using OMPS.PresentationKatmani.Abstraction;

namespace OMPS.PresentationKatmani.Controller
{
    public sealed class MainRoleAndRoleController : ApiController
    {
        public MainRoleAndRoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateMRARFCommand command,CancellationToken cancellationToken)
        {
            CreateMRARFResponse response = await _mediator.Send(command,cancellationToken);

            return Ok(response);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            GetAllMainRoleAndRoleQuery query = new();
            GetAllMainRoleAndRoleResponse response = await _mediator.Send(query);

            return Ok(response);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdMRARFCommand command)
        {         
            RemoveByIdMRARFResponse response = await _mediator.Send(command);

            return Ok(response);
        }

    }
}
