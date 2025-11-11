using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.CreateMainRoleAndUser;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.RemoveMainRoleAndUser;
using OMPS.PresentationKatmani.Abstraction;

namespace OMPS.PresentationKatmani.Controller
{
    public sealed class MainRoleAndUserController : ApiController
    {
        public MainRoleAndUserController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateMainRoleAndUserCommand command, CancellationToken cancellationToken)
        {
            CreateMainRoleAndUserResponse response= await _mediator.Send(command, cancellationToken);
            return Ok(response);

        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdMainRoleAndUserCommand command, CancellationToken cancellationToken)
        {
            RemoveByIdMainRoleAndUserResponse response = await _mediator.Send(command, cancellationToken);
            return Ok(response);

        }
    }
}
