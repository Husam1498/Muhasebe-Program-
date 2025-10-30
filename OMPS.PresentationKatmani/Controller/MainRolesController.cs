using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRole;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Queryies.GettAllMainRoleQuery;
using OMPS.PresentationKatmani.Abstraction;

namespace OMPS.PresentationKatmani.Controller
{
    public class MainRolesController : ApiController
    {
        public MainRolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateMainRole(CreateMainRoleCommand command,CancellationToken cancellationToken)
        {
            CreatemainRoleCommandsResponse response= await _mediator.Send(command, cancellationToken);

            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateStaticMainRole(CancellationToken cancellationToken)
        {
            CreateStaticMainRoleCommand command = new(null);
            CreateStaticMainRolecommandsResponse response= await _mediator.Send(command, cancellationToken);

            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllMainRole(GetAllMainRoleQuery query)
        {
            GetAllMainRoleResponse response= await _mediator.Send( query);

            return Ok(response);
        }


    }
}
