using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands;
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

    }
}
