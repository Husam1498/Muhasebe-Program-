using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.CreateRole;
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
    }
}
